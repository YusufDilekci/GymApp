using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class EtradeController : Controller
    {
        public EtradeController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
