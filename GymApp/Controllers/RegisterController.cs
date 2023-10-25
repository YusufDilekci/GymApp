using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class RegisterController : Controller
    {
        
        public RegisterController() 
        {
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Member m)
        {

            return RedirectToAction("Index", "Login");
        }
    }
}
