using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Web_API.Controllers
{
    [ApiController]
    [Route("/api/auth")]
    public class AuthController : Controller
    {
        private IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService= userService;
        }

        [Authorize]
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Ok("WELCOME");
        }

        [AllowAnonymous]
        [HttpGet("login")]
        public IActionResult Login()
        {
            var token = _userService.CreateAccessToken();
            return Ok(token.Token);
        }
    }
}
