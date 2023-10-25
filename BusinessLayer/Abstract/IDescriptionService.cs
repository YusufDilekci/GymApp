using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDescriptionService
    {
        void Add(Description description);
        void Update(Description description);
        void Delete(Description description);
        List<Description> GetAll();
        Description GetById(int id);
    }
}
