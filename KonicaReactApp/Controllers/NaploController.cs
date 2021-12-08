using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonicaReactApp.Models;
using KonicaReactApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace KonicaReactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NaploController : ControllerBase
    {
        public INaploRepository SqlNaploRepository { get; set; }

        public NaploController(INaploRepository naploRepository)
        {
            this.SqlNaploRepository = naploRepository;
        }

        [HttpGet("{id}")]
        public IEnumerable<dynamic> GetallEventsByDocumentId(int id)
        {
            return SqlNaploRepository.GetAllEventsByDocumentId(id);
        }
    }
}
