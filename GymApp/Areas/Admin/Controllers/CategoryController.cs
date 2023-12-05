using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GymApp.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GymApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService= categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryList()
        {
            var categories = _categoryService.GetAll().Select(i =>  new CategoryAjaxViewModel
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName
            }).ToList();
            var jsonlist = JsonConvert.SerializeObject(categories);
            return Json(jsonlist);
        }

        public IActionResult GetCategoryById(int categoryId)
        {
            var category = _categoryService.GetById(categoryId);
            var jsonCategory = JsonConvert.SerializeObject(category);
            return Json(jsonCategory);
        }

        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
 
            _categoryService.Add(c);
            var jsonCategory = JsonConvert.SerializeObject(c);
            return Json(jsonCategory);


        }

        public IActionResult DeleteCategory(int id)
        {
            var c = _categoryService.GetById(id);
            _categoryService.Delete(c);
            var jsonCategory = JsonConvert.SerializeObject(c);
            return Json(jsonCategory);
        }


        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            var c = _categoryService.GetById(category.CategoryId);
            _categoryService.Update(c);
            var jsonCat = JsonConvert.SerializeObject(category);
            return Json(jsonCat);
        }
    }
}
