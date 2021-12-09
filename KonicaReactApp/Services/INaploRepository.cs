using System.Linq;

namespace KonicaReactApp.Services
{
    public interface INaploRepository
    {
        public IQueryable<dynamic> GetAllEventsByDocumentId(int id);
    }
}
