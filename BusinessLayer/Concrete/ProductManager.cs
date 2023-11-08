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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        } 
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllBySubCategory(int subcategoryId)
        {
            return _productDal.GetAll(i => i.SubCategoryId == subcategoryId);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(i => i.ProductId == id);
        }

        public void Uodate(Product product)
        {
            _productDal.Update(product);
        }
    }
}
