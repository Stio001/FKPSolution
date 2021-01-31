using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.WebApi.Models;
using Authentication.WebApi.Models.DbModels;
using Authentication.WebApi.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Authentication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        readonly ILogger<TokenController> _logger;
        readonly UsersContext _usersContext;
        readonly ITokenService _tokenService;

        public TokenController(ILogger<TokenController> logger,
            UsersContext usersContext,
            ITokenService tokenService)
        {
            _logger = logger;
            _usersContext = usersContext;
            _tokenService = tokenService;
        }

        [HttpPost]
        public async Task<IActionResult> Refresh(TokenApiModel tokenApiModel)
        {
            if (tokenApiModel is null)
            {
                return BadRequest("Invalid client request");
            }

            string accessToken = tokenApiModel.AccessToken;
            string refreshToken = tokenApiModel.RefreshToken;

            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
            var username = principal.Identity.Name; //this is mapped to the Name claim by default

            _logger.LogInformation(principal.Identity.Name);

            var user = await _usersContext.AppUsers.SingleOrDefaultAsync(u => u.UserName == username);

            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                return BadRequest("Invalid client request");
            }

            var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            await _usersContext.SaveChangesAsync();

            return new ObjectResult(new
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            });
        }

        [HttpPost]
        public async Task<IActionResult> Revoke()
        {
            var username = User.Identity.Name;

            var user = await _usersContext.AppUsers.SingleOrDefaultAsync(u => u.UserName == username);
            if (user == null) return BadRequest();

            user.RefreshToken = null;

            await _usersContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
