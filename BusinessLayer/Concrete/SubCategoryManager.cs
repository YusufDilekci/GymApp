using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        private ISubCategoryDal _subcategoryDal;
        public SubCategoryManager(ISubCategoryDal subcategoryDal)
        {
            _subcategoryDal= subcategoryDal;
        }

        public void Add(SubCategory subcategory)
        {
            _subcategoryDal.Add(subcategory);
        }

        public void Delete(SubCategory subcategory)
        {
            _subcategoryDal.Delete(subcategory);
        }

        public List<SubCategory> GetAll()
        {
            return _subcategoryDal.GetAll();
        }

        public List<SubCategory> GetAllByCategory(int categoryId)
        {
            return _subcategoryDal.GetAll(i => i.CategoryId == categoryId);
        }

        public SubCategory GetById(int id)
        {
            return _subcategoryDal.Get(i => i.SubCategoryId == id);
        }

        public void Update(SubCategory subcategory)
        {
            _subcategoryDal.Update(subcategory);
        }
    }
}
