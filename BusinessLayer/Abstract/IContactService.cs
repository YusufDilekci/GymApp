using CoreLayer.Business;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService : IEntityManagerBase<Contact>
    {
        Contact GetById(int id);
        Contact GetLastContact();
    }
}
