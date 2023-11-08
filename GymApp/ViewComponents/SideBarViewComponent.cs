using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace GymApp.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;


        public SideBarViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Category>> GetItemsAsync()
        {
            return Task.FromResult(_categoryService!.GetAll());
        }
    }
}
