using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
