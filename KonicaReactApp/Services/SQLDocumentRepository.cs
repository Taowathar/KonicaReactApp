using System.Linq;
using KonicaReactApp.Data;
using KonicaReactApp.Models;
using Microsoft.EntityFrameworkCore;

namespace KonicaReactApp.Services
{
    public class SQLDocumentRepository : IDocumentRepository
    {
        private readonly konicaContext _context;

        public SQLDocumentRepository(konicaContext context)
        {
            this._context = context;
        }

        public IQueryable<Document> GetDocumentsByMainId(int mainId)
        {
            return _context.Dokumentumok.FromSqlRaw($"GetDocumentsByMainId {mainId}");
        }

        public Document GetDocumentById(int id)
        {
            return _context.Dokumentumok.First(doc => doc.Id == id);
        }

        public IQueryable<Document> GetDocumentsBySearchString(string searchString)
        {
            return _context.Dokumentumok.FromSqlRaw($"GetDocumentsBySearch {searchString}");
        }
    }
}
