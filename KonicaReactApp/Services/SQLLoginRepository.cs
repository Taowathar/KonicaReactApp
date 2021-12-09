using System.Linq;
using KonicaReactApp.Data;
using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public class SQLLoginRepository : ILoginRepository
    {
        private readonly konicaContext _context;

        public SQLLoginRepository(konicaContext context)
        {
            this._context = context;
        }

        public void AddLogin(Login login)
        {
            _context.Logins.Add(login);
            _context.SaveChanges();
        }

        public int GetFailedLogins(string userName)
        {
            return _context.Logins.Count(login => login.LoginName == userName && login.EventId == 2);
        }

        public bool GetAccountDisabled(string userName)
        {
            return _context.Logins.Count(login => login.LoginName == userName && login.EventId == 3) != 0;
        }
    }
}
