

using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GymApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GymApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBranchService _BranchService;
        private ITrainerService _trainerService;
        private IContactService _contactService;

        public HomeController(ILogger<HomeController> logger, IBranchService BranchService, ITrainerService trainerService,
            IContactService contactService
            )
        {
            _logger = logger;
            _BranchService = BranchService;
            _trainerService = trainerService;
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var categories = _BranchService.GetAllWithDescriptionAndImage().Select(i => new BranchDescriptionImageViewModel
            {
                BranchId = i.BranchId,
                BranchName = i.BranchName,
                BranchInfo = i.BranchInfo,
                BranchPrice = i.BranchPrice, 
                BranchDescriptions = i.Descriptions!.Where(x => x.BranchId == i.BranchId).Select(x => x.DescriptionName).ToList(),
                BranchImages = i.Images!.Where(x => x.BranchId == i.BranchId).Select(x => x.ImageName).ToList()
            }).ToList();

            return View(categories);
        }


        [Route("/Trainers")]
        public IActionResult Trainers()
        {
            var trainers = _trainerService.GetAll();
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

        public IActionResult Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View("Index");
            }

            var branch = _BranchService.GetByName(query);
            if (branch != null)
            {
                return RedirectToAction(string.Format("{0}", branch.BranchName), "Home", new { branchId = branch.BranchId });
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Route("/Contact")]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid) 
            {
                _contactService.Add(contact);
                return RedirectToAction("Index", "Home");
            }
            
            return View();
        }
        [Route("/Sport/{id?}")]
        public IActionResult Sport(int BranchId)
        {
            var model = new BranchDescriptionImageViewModel();

            var fitness = _BranchService.GetWithDescriptionAndImageById(BranchId);
            model.BranchId = fitness.BranchId;
            model.BranchName = fitness.BranchName;
            model.BranchInfo = fitness.BranchInfo;
            model.BranchPrice = fitness.BranchPrice;
            model.BranchDescriptions = fitness.Descriptions!.Where(x => x.BranchId == fitness.BranchId).Select(x => x.DescriptionName).ToList();
            model.BranchImages = fitness.Images!.Where(x => x.BranchId == fitness.BranchId).Select(x => x.ImageName).ToList();


            return View(model);
        }

    }
}