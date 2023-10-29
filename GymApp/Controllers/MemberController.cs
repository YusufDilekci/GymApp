using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{

    public class MemberController : Controller
    {
        private IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService= memberService;
        }

        public IActionResult Index()
        {
            var email = User.Identity.Name;
            if(email == null )
            {
                return NotFound();
            }
            var member = _memberService.GetByEmail(email);
            return View(member);
        }
    }
}
