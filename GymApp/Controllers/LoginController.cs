using EntityLayer.Concrete;
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
        public IActionResult Index(Member m)
        {
            
            return View();
        }
    }
}
