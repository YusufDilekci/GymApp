using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
