using CoreLayer.Entities.Concrete;
using CoreLayer.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void Add(AppUser user);
        void Delete(AppUser user);
        void Update(AppUser user);
        List<AppUser> GetAll();
        AppUser GetById(int id);
        AppUser GetByName(string username);
        AppUser GetByEmail(string email);
        AccessToken CreateAccessToken();



    }
}
