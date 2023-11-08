using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubCategoryService
    {
        void Add(SubCategory subcategory);
        void Delete(SubCategory subcategory);
        void Update(SubCategory subcategory);
        List<SubCategory> GetAll();
        SubCategory GetById(int id);
        List<SubCategory> GetAllByCategory(int categoryId);

    }
}
