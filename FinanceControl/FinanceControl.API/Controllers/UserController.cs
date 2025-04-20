using FinanceControl.Application.Factories;
using FinanceControl.Application.Interfaces;
using FinanceControl.Application.Services;
using FinanceControl.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewUser([FromBody] UserDTO user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _userService.CreateUser(user);
            return Ok("User created sucessfully");
        }
    }
}
