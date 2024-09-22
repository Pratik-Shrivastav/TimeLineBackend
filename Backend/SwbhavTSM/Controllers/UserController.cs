using Microsoft.AspNetCore.Mvc;
using SwbhavTSM.DTO;
using SwbhavTSM.Entity;
using SwbhavTSM.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwbhavTSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService) 
        {
           
            _userService = userService;
        }

        // POST api/<UserLoginController>
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserDto userDto)
        {
            var result = _userService.Login(userDto);
            if (result.Token == null)
            {
                return Unauthorized(new { message = result.Message }); ;
            }
            return Ok(result);
        }

        [HttpPost("Register")]
        public User Register([FromBody] User user)
        {
            return _userService.Register(user);

        }
    }
}
