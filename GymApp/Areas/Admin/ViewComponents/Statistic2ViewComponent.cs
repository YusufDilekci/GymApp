using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Areas.Admin.ViewComponents
{
    public class Statistic2ViewComponent : ViewComponent
    {
        private IContactService _contactService;
        public Statistic2ViewComponent(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contact = _contactService.GetLastContact();
            ViewBag.lastContact = contact.ContactContent;
            ViewBag.lastEmail = contact.ContactEmail;

            return View();
        } 
    }
}
