using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class PacketController : Controller
    {
        private IPacketService _packetService;
        private ICategoryService _categoryService;

        public PacketController(IPacketService packetService, ICategoryService categoryService)
        {
            _packetService = packetService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var packets = _packetService.GetAllWithCategory();
            var categories = _categoryService.GetAll();
            ViewBag.Categories = categories;
            return View(packets);
        }
    }
}
