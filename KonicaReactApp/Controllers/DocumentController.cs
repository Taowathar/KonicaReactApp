using System.Collections.Generic;
using KonicaReactApp.Models;
using KonicaReactApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace KonicaReactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        public IDocumentRepository SqlDocumentRepository { get; set; }

        public DocumentController(IDocumentRepository documentRepository)
        {
            this.SqlDocumentRepository = documentRepository;
        }

        [HttpGet("{mainId}")]
        public IEnumerable<dynamic> GetDocumentsByMainId(int mainId)
        {
            return SqlDocumentRepository.GetDocumentsByMainId(mainId);
        }
    }
}
