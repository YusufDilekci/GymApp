

using BusinessLayer.Abstract;
using GymApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace GymApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;

        }

        public IActionResult Index()
        {

            var categories = _categoryService.GetAll().Select(i => new CategoryDescriptionImageViewModel
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                CategoryInfo = i.CategoryInfo,
                CategoryPrice = i.CategoryPrice,
                CategoryImages = i.Images.Where(x => x.CategoryId == i.CategoryId).Select(x => x.ImageName).ToList(),
                CategoryDescriptions = i.Descriptions.Where(x => x.CategoryId == i.CategoryId).Select(x => x.DescriptionName).ToList()
            }).ToList();

            return View(categories);
        }


        [Route("/Privacy")]
        public IActionResult Privacy() 
        {
            return View();
        }

        [Route("/Trainers")]
        public IActionResult Trainers()
        {
            return View();
            
        }

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("/Fitness/{id?}")]
        public IActionResult Fitness()
        {
            return View();
        }
        [Route("/Kickbox/{id?}")]
        public IActionResult Kickbox()
        {
            
            return View();
        }

        [Route("/Pilates/{id?}")]
        public IActionResult Pilates()
        { 
            return View();
        }

        [Route("/Zumba/{id?}")]
        public IActionResult Zumba()
        {
            
            return View();
        }

        [Route("/Coaching/{id?}")]
        public IActionResult Coaching()
        {
            return View();
        }
    }
}