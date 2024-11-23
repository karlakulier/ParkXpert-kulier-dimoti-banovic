using Microsoft.AspNetCore.Mvc;
using ParkXplore.Application.Services;
using ParkXplore.Core.Entities;

namespace ParkXplore.Server.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase {
        private readonly IUserService _userService;

        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user) {
            var result = await _userService.CreateUserAsync(user);
            if (result)
                return Ok("User registered successfully.");
            return BadRequest("Registration failed.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string email, string password) {
            var user = await _userService.LoginAsync(email, password);
            if (user == null)
                return Unauthorized("Invalid email or password.");

            return Ok(new {
                message = "Login successful",
                username = user.Username,
                role = user.Role
            });
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(int userId) {
            var user = await _userService.GetUserByIdAsync(userId);
            if (user == null)
                return NotFound("User not found.");
            return Ok(user);
        }
    }
}
