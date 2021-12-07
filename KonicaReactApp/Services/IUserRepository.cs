using KonicaReactApp.Models;
using System.Collections.Generic;

namespace KonicaReactApp.Services
{
    public interface IUserRepository
    {
        User GetUserByName(string userName);
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
    }
}
