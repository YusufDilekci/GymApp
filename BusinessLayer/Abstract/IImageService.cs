using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IImageService
    {
        void Add(Image image);
        void Update(Image image);
        void Delete(Image image);
        List<Image> GetAll();
        Image GetById(int id);
    }
}
