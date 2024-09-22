using SwbhavTSM.Data;
using SwbhavTSM.Entity;

namespace SwbhavTSM.Repository
{
    public class UserRepository : IUserRepository
    {
        private UserDbContext _dbContect;
        public UserRepository(UserDbContext dbContect)
        {
            _dbContect = dbContect;
        }

        public User GetUser(string email)
        {
            return _dbContect.UserTable.FirstOrDefault(x => x.Email == email);
        }
        public User AddUser(User user)
        {
           _dbContect.UserTable.Add(user);
            _dbContect.SaveChanges();
            return user;
        }
    }
}
