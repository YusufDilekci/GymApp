using GymApp.Models;

namespace GymApp.DataAccess.Abstract
{
    public interface IUsersRepository
    {
        IQueryable<Users> Users { get; }
        void Add(Users users);
    }
}
