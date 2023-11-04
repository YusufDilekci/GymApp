
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class BranchController : Controller
    {
        
        public BranchController() 
        {
            
        }
        public IActionResult Index()
        {   
            return View();
        }
    }
}
