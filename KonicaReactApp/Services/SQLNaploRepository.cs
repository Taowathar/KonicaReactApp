﻿using System;
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
            return _context.Naplos
                .Join(_context.Esemenyek, naplo => naplo.EsemenyId, esemeny => esemeny.Id,
                    (naplo, esemeny) => new {id = naplo.DokumentumId, title = esemeny.Title, time = naplo.HappenedAt})
                .Where(esemeny => esemeny.id == id)
                .OrderBy(esemeny => esemeny.time);
        }
    }
}
