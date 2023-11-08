using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IShippingDetailService
    {
        void Add(ShippingDetail shippingDetail);
        void Delete(ShippingDetail shippingDetail);
        void Update(ShippingDetail shippingDetail);
        List<ShippingDetail> GetAll();
        ShippingDetail GetById(int id);
        List<ShippingDetail> GetAllByCart(int cartId);

    }
}
