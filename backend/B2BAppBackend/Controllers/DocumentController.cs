using Microsoft.AspNetCore.Mvc;
using B2BAppBackend.Models;
using B2BAppBackend.Services;

namespace B2BAppBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly DocumentService _documentService;

        public DocumentController(DocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpPost]
        public async Task<IActionResult> StoreDocumentEmbedding([FromBody] Document document)
        {
            await _documentService.StoreDocumentEmbeddingAsync(document);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocumentEmbedding(Guid id)
        {
            var document = await _documentService.GetDocumentEmbeddingAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return Ok(document);
        }
    }
}
