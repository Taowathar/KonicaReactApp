using System;
using System.Security.Cryptography;
using KonicaReactApp.Models;
using KonicaReactApp.Services;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
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

        [HttpPost("login")]
        public User CheckPassword(User user)
        {
            var currentUser = GetUserByName(user.UserName);
            if (currentUser == null)
            {
                return new User { UserName = "wrong" };
            }

            if (currentUser.Password.Equals(HashPassword(user.Password, currentUser.Salt).Item2))
            {
                return currentUser;
            }
            return null;
        }

        private Tuple<byte[], string> HashPassword(string userPassword, byte[] salt = null)
        {
            byte[] newSalt;
            if (salt == null)
            {
                newSalt = new byte[128 / 8];
                using var rngCsp = new RNGCryptoServiceProvider();
                rngCsp.GetNonZeroBytes(newSalt);
            }
            else
            {
                newSalt = salt;
            }

            var hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: userPassword,
                salt: newSalt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
            return Tuple.Create(newSalt, hashedPassword);
        }
    }
}
