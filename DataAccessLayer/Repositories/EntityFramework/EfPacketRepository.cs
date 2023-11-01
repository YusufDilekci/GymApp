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
    public class EfPacketRepository : EfEntityRepositoryBase<Packet, Context>, IPacketDal
    {
        public List<Packet> GetAllWithCategory()
        {

            using (Context context = new Context())
            {
                return context.Packets.Include(i => i.Categories).ThenInclude(x => x.Category).ToList();


            }
        }
    }
}
