using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonicaReactApp.Models;
using KonicaReactApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace KonicaReactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserRepository SqlUserRepository { get; set; }

        public UserController(IUserRepository userRepository)
        {
            this.SqlUserRepository = userRepository;
        }

        [HttpGet("name")]
        public User GetUserByName(string name)
        {
            return SqlUserRepository.GetUserByName(name);
        }

        [HttpPost]
        public void AddUser(User user)
        {
            var hashedPassword = HashPassword(user.Password);
            user.Id = Guid.NewGuid().ToString("N");
            user.Salt = hashedPassword.Item1;
            user.Password = hashedPassword.Item2;
            SqlUserRepository.AddUser(user);
        }

        private Tuple<byte[], string> HashPassword(string userPassword)
        {
            throw new NotImplementedException();
        }
    }
}
