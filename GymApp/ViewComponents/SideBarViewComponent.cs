using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace GymApp.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly IBranchService _BranchService;

        public SideBarViewComponent(IBranchService BranchService)
        {
            _BranchService = BranchService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Branch>> GetItemsAsync()
        {
            return Task.FromResult(_BranchService!.GetAll());
        }
    }
}
