using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public HeaderViewComponent(ICategoryService categoryService)
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
