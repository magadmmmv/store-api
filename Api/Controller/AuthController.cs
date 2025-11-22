using Api.Common;
using Api.Data;
using Api.Model;
using Api.ModelDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Api.Controller
{
    public class AuthController : StoreController
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AuthController(
            AppDbContext dbContext,
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager)
            : base(dbContext)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register(
            [FromBody] RegisterRequestDto registerRequestDto)
        {
            if (registerRequestDto == null)
            {
                return BadRequest(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = {"Некорректная модель запроса"}
                });
            }

            var userFromDb = await dbContext
                .AppUsers
                .FirstOrDefaultAsync(u => 
                    u.UserName.ToLower() == registerRequestDto.UserName.ToLower());

            if (userFromDb != null)
            {
                return BadRequest(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = { "Такой пользователь есть" }
                });
            }

            var newAppUser = new AppUser
            {
                UserName = registerRequestDto.UserName,
                Email = registerRequestDto.Email,
                NormalizedEmail = registerRequestDto.Email.ToUpper(),
                FirstName = registerRequestDto.UserName
            };

            var result = await userManager.CreateAsync(
                newAppUser, registerRequestDto.Password);

            if (!result.Succeeded)
            {
                return BadRequest(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = { "Ошибка регистрации" }
                });
            }

            var newRoleAppUser = registerRequestDto.Role.Equals(
                SharedData.Roles.Admin, StringComparison.OrdinalIgnoreCase)
                ? SharedData.Roles.Admin
                : SharedData.Roles.Comsumer;

            await userManager.AddToRoleAsync(newAppUser, newRoleAppUser);
            return Ok(new ResponseServer
            {
                StatusCode = HttpStatusCode.OK,
                Result = "Регистрация завершена"
            });
        }
    }
}
