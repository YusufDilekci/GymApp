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
    public class EfCartLineRepository : EfEntityRepositoryBase<CartLine, Context>, ICartLineDal
    {
        public List<CartLine> GetAllWithProductByCart(int cartId)
        {
            using (Context context = new Context())
            {
                return context.CartLines.Include(i => i.Product).Where(x => x.CartId == cartId).ToList();
            }
        }
    }
}
