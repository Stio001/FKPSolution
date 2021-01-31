using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Authentication.WebApi.Models;
using Authentication.WebApi.Models.DbModels;
using Authentication.WebApi.Services.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Authentication.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        readonly ILogger<AuthController> _logger;
        readonly UsersContext _usersContext;
        readonly ITokenService _tokenService;
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;

        public AuthController(ILogger<AuthController> logger,
            UsersContext usersContext,
            ITokenService tokenService,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _usersContext = usersContext;
            _tokenService = tokenService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (loginModel == null)
                return BadRequest("Invalid client request");

            var user = await _userManager.FindByNameAsync(loginModel.UserName);

            if (user == null)
                return Unauthorized();

            await _signInManager.SignOutAsync();
            SignInResult result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
            if (result != SignInResult.Success)
                return Unauthorized();

            //var claimsPrincipal = await _signInManager.CreateUserPrincipalAsync(user);

            var claims = new List<Claim>()
            {
                new Claim("Id", user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
            };
            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
            {
                claims.Add(new Claim("Role", role));
            }

            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

            await _usersContext.SaveChangesAsync();

            return Ok(new
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            });
        }
    }
}
