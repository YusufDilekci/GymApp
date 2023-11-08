using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController()
        {
 
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int categoryId)
        {
            ViewBag.CategoryId = categoryId;
            return View();
        }
    }
}
