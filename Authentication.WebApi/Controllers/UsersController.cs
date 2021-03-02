using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.WebApi.Models.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Authentication.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersContext _usersContext;
        private readonly UserManager<AppUser> _userManager;

        public UsersController(UsersContext usersContext,
            UserManager<AppUser> userManager)
        {
            _usersContext = usersContext;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _userManager.Users.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return new ObjectResult(await _userManager.FindByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AppUser user)
        {
            try
            {
                await _userManager.UpdateAsync(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                var result = await _userManager.DeleteAsync(user);

                if (result == IdentityResult.Success)
                    return Ok();

                return BadRequest("Ошибка.");
            }

            return BadRequest("Пользователь не найден.");
        }
    }
}
