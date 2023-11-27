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
    public class AdminManager : EntityManagerBase<Admin, IAdminDal>, IAdminService
    {
        private IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal) : base(adminDal)
        {
            _adminDal= adminDal;
        }

        public Admin GetByUsername(string username)
        {
            return _adminDal.Get(i => i.Username == username);
        }
    }
}
