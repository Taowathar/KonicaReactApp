using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonicaReactApp.Data;
using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public class SQLNaploRepository : INaploRepository
    {
        private readonly konicaContext _context;

        public SQLNaploRepository(konicaContext context)
        {
            this._context = context;
        }

        public IQueryable<dynamic> GetAllEventsByDocumentId(int id)
        {
            throw new NotImplementedException();

        }
    }
}
