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
        public IEnumerable<Document> GetDocumentsByMainId(int mainId)
        {
            return SqlDocumentRepository.GetDocumentsByMainId(mainId);
        }

        [HttpGet("title/{id}")]
        public Document GetDocumentById(int id)
        {
            return SqlDocumentRepository.GetDocumentById(id);
        }

        [HttpGet("search/{searchString}")]
        public IEnumerable<Document> GetDocumentsBySearchString(string searchString)
        {
            return SqlDocumentRepository.GetDocumentsBySearchString(searchString);
        }
    }
}
