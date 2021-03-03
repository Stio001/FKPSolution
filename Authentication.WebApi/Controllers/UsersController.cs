using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.WebApi.Models;
using Authentication.WebApi.Models.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Authentication.WebApi.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            AppUser user = new AppUser()
            {
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result == IdentityResult.Success)
                return Ok();

            return BadRequest(result.Errors);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
                return BadRequest("Пользователь не найден.");

            user.Email = model.Email;
            user.LockoutEnd = model.LockoutEnd;

            var result = await _userManager.UpdateAsync(user);

            if (result == IdentityResult.Success)
                return Ok();

            return BadRequest(result.Errors);
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

        [HttpPut("changepassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);

            if (user == null)
                return BadRequest("Пользователь не найден");

            var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (result == IdentityResult.Success)
                return Ok();

            return BadRequest(result.Errors);
        }
    }
}
