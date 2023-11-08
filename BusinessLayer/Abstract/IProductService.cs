using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Uodate(Product product);
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetAllBySubCategory(int subcategoryId);

    }
}
