using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
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
        private IMemberService _memberService;
        private ICartService _cartService;
        public RegisterUserController(UserManager<AppUser> userManager, IMemberService memberService, ICartService cartService)
        {
            _userManager = userManager;
            _memberService = memberService;
            _cartService = cartService;
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
                    Member member = new Member()
                    {
                        MemberEmail = s.Email,
                        MemberUserName = s.UserName,
                        MemberNameSurname = s.NameSurname,
                        MemberPassword = s.Password,
                        MemberStatus = true
                    };

                    _memberService.Add(member);

                    Cart cart = new Cart()
                    {
                        MemberId = member.MemberId
                    };

                    _cartService.Add(cart);

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
