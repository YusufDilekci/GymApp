using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using CoreLayer.Utilities.Security.JWT;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private ITokenHelper _tokenHelper;
        public UserManager(IUserDal userDal, ITokenHelper tokenHelper)
        {
            _userDal = userDal;
            _tokenHelper = tokenHelper;
        }
        public void Add(AppUser user)
        {
            _userDal.Add(user);
        }

        public AccessToken CreateAccessToken()
        {
            return _tokenHelper.CreateToken();
        }

        public void Delete(AppUser user)
        {
            _userDal.Delete(user); ;
        }

        public List<AppUser> GetAll()
        {
            return _userDal.GetAll();
        }

        public AppUser GetByEmail(string email)
        {
            return _userDal.Get(i => i.Email == email);
        }

        public AppUser GetById(int id)
        {
            return _userDal.Get(i => i.Id == id);
        }

        public AppUser GetByName(string username)
        {
            return _userDal.Get(i => i.UserName == username);
        }

        public void Update(AppUser user)
        {
            _userDal.Update(user); ;
            
        }
    }
}
