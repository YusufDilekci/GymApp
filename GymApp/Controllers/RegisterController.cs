using EntityLayer.Concrete;
using GymApp.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class RegisterController : Controller
    {
        private IUsersRepository _usersRepository;
        public RegisterController(IUsersRepository usersRepository) 
        {
            _usersRepository= usersRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Member u)
        {
            u.UserStatus = true;
            _usersRepository.Add(u);
            return RedirectToAction("Index", "Login");
        }
    }
}
