using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using KonicaReactApp.Data;
using KonicaReactApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient;

namespace KonicaReactApp.Services
{
    public class SQLDocumentRepository : IDocumentRepository
    {
        private readonly konicaContext _context;

        public SQLDocumentRepository(konicaContext context)
        {
            this._context = context;
        }

        public IQueryable<dynamic> GetDocumentsByMainId(int mainId)
        {
            return _context.Dokumentumok
                .Join(_context.Naplos, document => document.Id, naplo => naplo.DokumentumId, (document, naplo) => new
                    { id = document.Id, title = document.Title, extension = document.Extension, mainId = document.MainId, source = document.Source, type = naplo.EsemenyId, time = naplo.HappenedAt })
                .Where(doc => doc.type == 1 && doc.mainId == mainId)
                .GroupBy(doc => new { doc.id, doc.title, doc.extension, doc.mainId, doc.source, doc.time })
                .Select(doc => new { id = doc.Key.id, title = doc.Key.title, extension = doc.Key.extension, mainId = doc.Key.mainId, source = doc.Key.source, time = doc.Key.time })
                .OrderBy(doc => doc.time);
        }
    }
}
