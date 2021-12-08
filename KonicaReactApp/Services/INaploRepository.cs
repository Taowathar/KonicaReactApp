
using System.Collections.Generic;
using System.Linq;
using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public interface INaploRepository
    {
        public IQueryable<dynamic> GetAllEventsByDocumentId(int id);
    }
}
