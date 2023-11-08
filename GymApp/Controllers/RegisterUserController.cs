using CoreLayer.Entities.Concrete;
using GymApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SignUpViewModel s)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = s.Email,
                    UserName = s.UserName,
                    NameSurname = s.NameSurname,

                };

                var result = await _userManager.CreateAsync(user, s.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
