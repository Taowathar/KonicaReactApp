using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public interface IDocumentRepository
    {
        public IEnumerable<Document> GetDocumentsByMainId(int id);
    }
}
