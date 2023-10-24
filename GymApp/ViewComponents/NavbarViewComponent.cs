using GymApp.DataAccess.Abstract;
using GymApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymApp.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        //private readonly ToDoContext db;

        //public PriorityListViewComponent(ToDoContext context) => db = context;
        private readonly ICategoryRepository _categoryRepository;

        public NavbarViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository= categoryRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Category>> GetItemsAsync()
        {
            return Task.FromResult(_categoryRepository!.Categories!.ToList());
        }
    }
}
