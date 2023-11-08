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
    public class CartLineManager : ICartLineService
    {
        private ICartLineDal _cartLineDal;

        public CartLineManager(ICartLineDal cartLineDal)
        {
            _cartLineDal= cartLineDal;
        }
        public void Add(CartLine cartLine)
        {
            _cartLineDal.Add(cartLine);
        }

        public void Delete(CartLine cartLine)
        {
            _cartLineDal.Delete(cartLine);
        }

        public List<CartLine> GetAll()
        {
            return _cartLineDal.GetAll();
        }

        public List<CartLine> GetAllWithProductByCart(int cartId)
        {
            return _cartLineDal.GetAllWithProductByCart(cartId);
        }

        public CartLine GetByCartAndProduct(int cartId, int productId)
        {
            return _cartLineDal.Get(i => i.CartId == cartId && i.ProductId == productId);
        }

        public CartLine GetById(int id)
        {
            return _cartLineDal.Get(i => i.CartLineId == id);
        }

        public void Update(CartLine cartLine)
        {
            _cartLineDal.Update(cartLine);
        }
    }
}
