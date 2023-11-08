using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICartLineService
    {
        void Add(CartLine cartLine);
        void Delete(CartLine cartLine);
        void Update(CartLine cartLine);
        List<CartLine> GetAll();
        CartLine GetById(int id);
        CartLine GetByCartAndProduct(int cartId, int productId);
        List<CartLine> GetAllWithProductByCart(int cartId);
    }
}
