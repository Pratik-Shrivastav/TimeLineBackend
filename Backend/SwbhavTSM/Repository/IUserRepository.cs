using SwbhavTSM.Entity;

namespace SwbhavTSM.Repository
{
    public interface IUserRepository
    {
        public User GetUser(string email);
        public User AddUser(User user);
    }
}
