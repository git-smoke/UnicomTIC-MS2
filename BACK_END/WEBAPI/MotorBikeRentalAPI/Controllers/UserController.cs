using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotorBikeRentalAPI.DTOs.UserDTO;
using MotorBikeRentalAPI.IServices;
using MotorBikeRentalAPI.Models;

namespace MotorBikeRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        } 

        [HttpPost("login")]
        public IActionResult Login([FromBody] User loginDto)
        {
            var user = _userService.Authenticate(loginDto.UserName, loginDto.Password_Hash);
            if (user == null)
            {
                return Unauthorized("Invalid credentials");
            }

            if (user.User_Type == "Customer")
            {
                _userService.UpdateLastLogin(user.Id);
            }

            // Redirect based on role
            string redirectUrl = user.User_Type == "" ? "/adminDashboard" : "/customerDashboard";
            return Ok(new { Role = user.User_Type, RedirectUrl = redirectUrl });
        }
    }
}
