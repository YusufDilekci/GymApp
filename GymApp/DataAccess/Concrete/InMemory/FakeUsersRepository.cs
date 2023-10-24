using GymApp.DataAccess.Abstract;
using GymApp.Models;

namespace GymApp.DataAccess.Concrete.InMemory
{
    public class FakeUsersRepository : IUsersRepository
    {
        private IQueryable<Users> _users;
        public IQueryable<Users> Users => _users;

        public FakeUsersRepository() 
        {
            _users = new List<Users>().AsQueryable();
        }
        public void Add(Users users)
        {
            _users.ToList().Add(users);
        }
    }
}
