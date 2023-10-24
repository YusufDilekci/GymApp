using GymApp.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class CategoryController : Controller
    {
        private IUsersRepository _usersRepository;
        public CategoryController(IUsersRepository usersRepository) 
        {
            _usersRepository= usersRepository;
        }
        public IActionResult Index(int userId)
        {
            var newUser = _usersRepository.Users.Where(i => i.UserId== userId).FirstOrDefault();
            return View(newUser);
        }
    }
}
