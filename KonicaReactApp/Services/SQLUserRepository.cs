using System.Collections.Generic;
using System.Linq;
using KonicaReactApp.Data;
using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public class SQLUserRepository : IUserRepository
    {

        private readonly konicaContext _context;

        public SQLUserRepository(konicaContext context)
        {
            this._context = context;
        }

        public User GetUserByName(string userName)
        {
            return _context.Users.FirstOrDefault(user => user.UserName == userName);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
