using SwbhavTSM.DTO;
using SwbhavTSM.Entity;

namespace SwbhavTSM.Service
{
    public interface IUserService
    {
        public LoginResponse Login(UserDto userDto);
        public User Register(User user);
    }
}
