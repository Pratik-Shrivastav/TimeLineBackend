using Azure.Core;
using Microsoft.AspNetCore.Identity;
using SwbhavTSM.CommonFunction;
using SwbhavTSM.DTO;
using SwbhavTSM.Entity;
using SwbhavTSM.Repository;

namespace SwbhavTSM.Service
{
    public class UserService : IUserService
    {
        private IConfiguration _configuration;
        private IUserRepository _userRepository;
        public UserService(IConfiguration configuration, IUserRepository userRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }
        public LoginResponse Login(UserDto userDto)
        {
            LoginResponse loginResponse = new LoginResponse();
            User user = _userRepository.GetUser(userDto.Email);
            if (user == null)
            {
                loginResponse.Message = "User Not Found";
                return loginResponse;
            }
            bool pass = BCrypt.Net.BCrypt.EnhancedVerify(userDto.Password, user.Password);
            if (user != null && pass)
            {
                loginResponse.Token= GenerateToken.GetToken(user, _configuration);
                loginResponse.Message = "Login Success";
            }
            else
            {
                loginResponse.Message = "Bad Credentials";
            }
            return loginResponse;
        }
        public User Register(User user)
        {
            user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
            return _userRepository.AddUser(user);
        }
    }
}
