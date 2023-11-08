using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICartService
    {
        void Add(Cart cart);
        void Delete(Cart cart);
        void Update(Cart cart);
        void ClearCartLines(int cartId);
        List<Cart> GetAll();
        Cart GetById(int id);
        Cart GetByMember(int memberId);
        double TotalPrice(int cartId);

    }
}
