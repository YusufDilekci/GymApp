using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class PacketController : Controller
    {
        private IPacketService _packetService;
        private IBranchService _BranchService;

        public PacketController(IPacketService packetService, IBranchService BranchService)
        {
            _packetService = packetService;
            _BranchService = BranchService;
        }
        public IActionResult Index()
        {
            var packets = _packetService.GetAllWithBranch();
            var branches = _BranchService.GetAll();
            ViewBag.Branches = branches;
            return View(packets);
        }
    }
}
