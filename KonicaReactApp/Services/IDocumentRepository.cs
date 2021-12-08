using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public interface IDocumentRepository
    {
        public IQueryable<dynamic> GetDocumentsByMainId(int mainId);
        public Document GetDocumentById(int id);
    }
}
