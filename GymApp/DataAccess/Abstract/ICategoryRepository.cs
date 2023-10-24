using GymApp.Models;
using System.Reflection.Metadata;

namespace GymApp.DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories { get; }
        void Add(Category category);
    }
}
