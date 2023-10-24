using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Users users)
        {
            var a = User.Identity.Name;
            return View();
        }
    }
}
