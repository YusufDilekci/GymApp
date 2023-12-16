using BusinessLayer.Abstract;
using GymApp.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ChartController : Controller
    {
        private ICategoryService _categoryService;

        public ChartController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            var categories = _categoryService.GetAllWithProducts().GroupBy(i => i.CategoryName).Select(j => new CategoryChartViewModel
            {
                CategoryName = j.Key,
                ProductCount = j.Count()
            });
            return Json(new { jsonlist = categories});
        }
    }
}
