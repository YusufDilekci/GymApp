using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.ViewComponents
{
    public class SubCategoryCardsViewComponent : ViewComponent
    {
        private readonly ISubCategoryService _subcategoryService;

        public SubCategoryCardsViewComponent(ISubCategoryService subcategoryService)
        {
            _subcategoryService = subcategoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
            var items = await GetItemsAsync(categoryId);
            return View(items);
        }

        private Task<List<SubCategory>> GetItemsAsync(int categoryId)
        {
            return Task.FromResult(_subcategoryService!.GetAllByCategory(categoryId));
        }
    }
}
