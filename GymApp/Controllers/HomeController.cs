using GymApp.DataAccess.Abstract;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace GymApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITrainerRepository _trainerRepository;
        private readonly ICategoryRepository _categoryRepository;
        public HomeController(ILogger<HomeController> logger, ITrainerRepository trainerRepository, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _trainerRepository = trainerRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            
            var categories = _categoryRepository.Categories.ToList();
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
            var trainers = _trainerRepository.Trainers.ToList();
            return View(trainers);
            
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
        public IActionResult Fitness(int categoryId)
        {
            var category = _categoryRepository.Categories.Where(i => i.CategoryId == categoryId).FirstOrDefault();
            return View(category);
        }
        [Route("/Kickbox/{id?}")]
        public IActionResult Kickbox(int categoryId)
        {
            var category = _categoryRepository.Categories.Where(i => i.CategoryId == categoryId).FirstOrDefault();
            return View(category);
        }

        [Route("/Pilates/{id?}")]
        public IActionResult Pilates(int categoryId)
        {
            var category = _categoryRepository.Categories.Where(i => i.CategoryId == categoryId).FirstOrDefault();
            return View(category);
        }

        [Route("/Zumba/{id?}")]
        public IActionResult Zumba(int categoryId)
        {
            var category = _categoryRepository.Categories.Where(i => i.CategoryId == categoryId).FirstOrDefault();
            return View(category);
        }

        [Route("/Coaching/{id?}")]
        public IActionResult Coaching(int categoryId)
        {
            var category = _categoryRepository.Categories.Where(i => i.CategoryId == categoryId).FirstOrDefault();
            return View(category);
        }
    }
}