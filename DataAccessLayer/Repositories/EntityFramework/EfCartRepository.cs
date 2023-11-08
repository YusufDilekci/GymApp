using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfCartRepository : EfEntityRepositoryBase<Cart, Context>, ICartDal
    {
        public void ClearCartLines(int cartId)
        {
            using (Context context = new Context())
            {
                foreach(var cartline in context.CartLines.Where(i => i.CartId == cartId))
                {
                    context.CartLines.Remove(cartline);
                }
            };
        }

        public  Cart GetWithCartLines(int cartId)
        {
            using (Context context = new Context())
            {
                return context.Carts.Include(i => i.CartLines).ThenInclude(i => i.Product).Where(i => i.CartId == cartId).FirstOrDefault();
            };
        }
    }
}
