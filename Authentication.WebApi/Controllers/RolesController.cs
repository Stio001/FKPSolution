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
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly UsersContext _usersContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(UsersContext usersContext, 
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _usersContext = usersContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _roleManager.Roles.ToListAsync());
        }

        [HttpPost("{roleName}")]
        public async Task<IActionResult> Create(string roleName)
        {
            if (string.IsNullOrEmpty(roleName))
                return BadRequest("Название роли не может быть пустым.");

            var result = await _roleManager.CreateAsync(new IdentityRole(roleName));

            if (result == IdentityResult.Success)
                return Ok();

            return BadRequest(result.Errors);
        }

        [HttpDelete("{roleId}")]
        public async Task<IActionResult> Delete(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
                return BadRequest("Роль не найдена.");

            var result = await _roleManager.DeleteAsync(role);

            if (result == IdentityResult.Success)
                return Ok();

            return BadRequest(result.Errors);
        }

        [HttpGet("{roleId}")]
        public async Task<IActionResult> Get(string roleId)
        {
            return new ObjectResult(await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == roleId));
        }

        [HttpGet("getuserroles/{userId}")]
        public async Task<IActionResult> GetUserRoles(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return BadRequest("Пользователь не найден.");

            var userRoles = await _userManager.GetRolesAsync(user);

            return new ObjectResult(userRoles);
        }

        [HttpPut("changeuserroles/{userId}")]
        public async Task<IActionResult> ChangeUserRoles(string userId, List<string> roles)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return BadRequest("Пользователь не найден.");

            var userRoles = await _userManager.GetRolesAsync(user);
            var allRoles = await _roleManager.Roles.ToListAsync();
            var addedRoles = roles.Except(userRoles);
            var removedRoles = userRoles.Except(roles);

            await _userManager.AddToRolesAsync(user, addedRoles);
            await _userManager.RemoveFromRolesAsync(user, removedRoles);

            return Ok();
        }
    }
}
