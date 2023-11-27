using BusinessLayer.Abstract;
using CoreLayer.Business.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : EntityManagerBase<Contact, IContactDal>,IContactService
    {
        private IContactDal _contactDal;
        public ContactManager(IContactDal contactDal) : base(contactDal)
        {
            _contactDal = contactDal;
            
        }
        public Contact GetById(int id)
        {
            return _contactDal.Get(i => i.ContactId == id);
        }

        public Contact GetLastContact()
        {
            return _contactDal.GetLastContact();
        }


    }
}
