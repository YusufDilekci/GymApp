using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Areas.Admin.ViewComponents
{
    public class Statistic4ViewComponent : ViewComponent
    {
        private IAdminService _adminService;
        public Statistic4ViewComponent(IAdminService adminService)
        {
            _adminService= adminService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var username = User.Identity.Name;
            var admin = _adminService.GetByUsername("DarkMaster");
            ViewBag.adminName = admin.Name;
            ViewBag.adminImage = admin.ImageURL;
            ViewBag.adminDescription = admin.ShortDescription;
            return View();
        }
    }
}
