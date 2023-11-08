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
    public class ShippingDetailManager : IShippingDetailService
    {
        private IShippingDetailDal _shippingDetailDal;

        public ShippingDetailManager(IShippingDetailDal shippingDetailDal)
        {
            _shippingDetailDal= shippingDetailDal;
        }
        public void Add(ShippingDetail shippingDetail)
        {
            _shippingDetailDal.Add(shippingDetail);
        }

        public void Delete(ShippingDetail shippingDetail)
        {
            _shippingDetailDal.Delete(shippingDetail);
        }

        public List<ShippingDetail> GetAll()
        {
            return _shippingDetailDal.GetAll();
        }

        public List<ShippingDetail> GetAllByCart(int cartId)
        {
            return _shippingDetailDal.GetAll(i => i.CartId == cartId);
        }

        public ShippingDetail GetById(int id)
        {
            return _shippingDetailDal.Get(i => i.Id == id);
        }

        public void Update(ShippingDetail shippingDetail)
        {
            _shippingDetailDal.Update(shippingDetail);
        }
    }
}
