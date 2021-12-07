using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using KonicaReactApp.Data;
using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public class SQLDocumentRepository : IDocumentRepository
    {
        private readonly konicaContext _context;

        public SQLDocumentRepository(konicaContext context)
        {
            this._context = context;
        }
        public IEnumerable<Document> GetDocumentsByMainId(int id)
        {
            return _context.Dokumentumok.Where(doc => doc.MainId == id);
        }
    }
}
