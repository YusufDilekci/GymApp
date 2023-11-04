

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
                BranchPrice = i.BranchPrice, //AQ entityframeworkcoru navigation props çalışmıyor.
                                                 //Not: Include method kullanmak gerekiyormuş Sorry entito
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

            var Branch = _BranchService.GetByName(query);
            if (Branch != null)
            {
                return RedirectToAction(string.Format("{0}", Branch.BranchName), "Home", new { BranchId = Branch.BranchId });
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
        [Route("/Fitness/{id?}")]
        public IActionResult Fitness(int BranchId)
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
        [Route("/Kickbox/{id?}")]
        public IActionResult Kickbox(int BranchId)
        {

            var model = new BranchDescriptionImageViewModel();

            var kickbox = _BranchService.GetWithDescriptionAndImageById(BranchId);
            model.BranchId = kickbox.BranchId;
            model.BranchName = kickbox.BranchName;
            model.BranchInfo = kickbox.BranchInfo;
            model.BranchPrice = kickbox.BranchPrice;
            model.BranchDescriptions = kickbox.Descriptions!.Where(x => x.BranchId == kickbox.BranchId).Select(x => x.DescriptionName).ToList();
            model.BranchImages = kickbox.Images!.Where(x => x.BranchId == kickbox.BranchId).Select(x => x.ImageName).ToList();

            return View(model);
        }

        [Route("/Pilates/{id?}")]
        public IActionResult Pilates(int BranchId)
        {
            var model = new BranchDescriptionImageViewModel();

            var pilates = _BranchService.GetWithDescriptionAndImageById(BranchId);
            model.BranchId = pilates.BranchId;
            model.BranchName = pilates.BranchName;
            model.BranchInfo = pilates.BranchInfo;
            model.BranchPrice = pilates.BranchPrice;
            model.BranchDescriptions = pilates.Descriptions!.Where(x => x.BranchId == pilates.BranchId).Select(x => x.DescriptionName).ToList();
            model.BranchImages = pilates.Images!.Where(x => x.BranchId == pilates.BranchId).Select(x => x.ImageName).ToList();

            return View(model);
        }

        [Route("/Zumba/{id?}")]
        public IActionResult Zumba(int BranchId)
        {

            var model = new BranchDescriptionImageViewModel();

            var zumba = _BranchService.GetWithDescriptionAndImageById(BranchId);
            model.BranchId = zumba.BranchId;
            model.BranchName = zumba.BranchName;
            model.BranchInfo = zumba.BranchInfo;
            model.BranchPrice = zumba.BranchPrice;
            model.BranchDescriptions = zumba.Descriptions!.Where(x => x.BranchId == zumba.BranchId).Select(x => x.DescriptionName).ToList();
            model.BranchImages = zumba.Images!.Where(x => x.BranchId == zumba.BranchId).Select(x => x.ImageName).ToList();

            return View(model);
        }

        [Route("/Futbol/{id?}")]
        public IActionResult Futbol(int BranchId)
        {
            var model = new BranchDescriptionImageViewModel();

            var futbol = _BranchService.GetWithDescriptionAndImageById(BranchId);
            model.BranchId = futbol.BranchId;
            model.BranchName = futbol.BranchName;
            model.BranchInfo = futbol.BranchInfo;
            model.BranchPrice = futbol.BranchPrice;
            model.BranchDescriptions = futbol.Descriptions!.Where(x => x.BranchId == futbol.BranchId).Select(x => x.DescriptionName).ToList();
            model.BranchImages = futbol.Images!.Where(x => x.BranchId == futbol.BranchId).Select(x => x.ImageName).ToList();

            return View(model);
        }
    }
}