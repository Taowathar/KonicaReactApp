using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
