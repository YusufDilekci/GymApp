using GymApp.DataAccess.Abstract;
using GymApp.Models;

namespace GymApp.DataAccess.Concrete.InMemory
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        private IQueryable<Category> _categories;
        public FakeCategoryRepository() 
        {
            _categories = new List<Category>
            {
                new Category(){CategoryId=1, CategoryName="Fitness", CategoryInfo="üiğiüğğşğşsğaüğ", CategoryDescriptions= {"asjajjsakja", "hashhgsag", "hasıuhıuah"}, CategoryImages = { "fitness1.jpg", "fitness2.jpg", "fitness3.jpg" }},
                new Category(){CategoryId=2, CategoryName="Kickbox", CategoryInfo="üiğiüğğşğşsğaüğ",  CategoryDescriptions= {"asjajjsakja", "hashhgsag", "hasıuhıuah"}, CategoryImages = { "kickbox1.jpg", "kickbox2.jpg", "kickbox3.jpg" }},
                new Category(){CategoryId=3, CategoryName="Zumba",  CategoryInfo="üiğiüğğşğşsğaüğ", CategoryDescriptions = { "asjajjsakja", "hashhgsag", "hasıuhıuah" }, CategoryImages = { "zumba1.jpg", "zumba2.jpg", "zumba3.jpg" }},
                new Category(){CategoryId=4, CategoryName="Pilates",  CategoryInfo="üiğiüğğşğşsğaüğ", CategoryDescriptions = { "asjajjsakja", "hashhgsag", "hasıuhıuah" }, CategoryImages = { "pilates1.jpg", "pilates2.jpg", "pilates3.jpg" }},
                new Category(){CategoryId=5, CategoryName="Coaching",  CategoryInfo="üiğiüğğşğşsğaüğ", CategoryDescriptions = { "asjajjsakja", "hashhgsag", "hasıuhıuah" }, CategoryImages = { "coaching1.jpg", "coaching2.jpg", "coaching3.jpg" }},

            }.AsQueryable();
        }

        public IQueryable<Category> Categories { get { return _categories; } }
        public void Add(Category category)
        {
            _categories.ToList().Add(category);
        }
    }
}
