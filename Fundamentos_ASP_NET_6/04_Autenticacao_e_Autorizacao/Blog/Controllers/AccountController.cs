using Blog.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AccountController : ControllerBase
    {
        [HttpPost("v1/login")]
        public IActionResult Login([FromServices]TokenService tokenService)
        {
            var token = tokenService.GenerateToken(null);
            return Ok(token);
        }

        [Authorize(Roles = "user")]
        [HttpGet("v1/user")]
        public IActionResult GetUser() => Ok(User.Identity.Name);

        [Authorize(Roles = "autor")]
        [Authorize]
        [HttpGet("v1/autor")]
        public IActionResult GetAutor() => Ok(User.Identity.Name);

        [Authorize(Roles = "admin")]
        [Authorize]
        [HttpGet("v1/admin")]
        public IActionResult GetAdmin() => Ok(User.Identity.Name);

    }
}
