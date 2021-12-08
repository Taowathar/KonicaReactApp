using System.Linq;
using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public interface IDocumentRepository
    {
        public IQueryable<Document> GetDocumentsByMainId(int mainId);
        public Document GetDocumentById(int id);
    }
}
