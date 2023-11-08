using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{

    public class MemberController : Controller
    {
        private IUserService _userService;

        public MemberController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var username = User.Identity!.Name;
            if(username == null)
            {
                return NotFound();
            }
            var user = _userService.GetByName(username);
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
