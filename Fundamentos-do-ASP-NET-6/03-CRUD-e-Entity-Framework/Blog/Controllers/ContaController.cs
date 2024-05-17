using Blog.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
public class ContaController : ControllerBase
{
    [HttpPost("v1/login")]
    public IActionResult Login([FromServices] TokenService tokenService)
    {
        var token = tokenService.GerarToken(null);
        return Ok(new { token });
    }

    [Authorize(Roles = "usuario")]
    [HttpGet("v1/usuario")]
    public IActionResult ObterUsuario() => Ok(User.Identity.Name);

    [Authorize(Roles = "autor")]
    [HttpGet("v1/autor")]
    public IActionResult ObterAutor() => Ok(User.Identity.Name);

    [Authorize(Roles = "admin")]
    [HttpGet("v1/admin")]
    public IActionResult ObterAdmin() => Ok(User.Identity.Name);
}

