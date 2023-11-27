using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfContactRepository : EfEntityRepositoryBase<Contact, Context>, IContactDal
    {
        public Contact GetLastContact()
        {
            using (Context context = new Context())
            {
                var lastContact = context.Contacts.OrderByDescending(i => i.ContactId).FirstOrDefault();

                return lastContact;
            }

        }
    }
}
