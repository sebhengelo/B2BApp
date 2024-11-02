using B2BAppBackend.Models;
using B2BAppBackend.Repositories;
using System;
using System.Threading.Tasks;

namespace B2BAppBackend.Services
{
    public class DocumentService
    {
        private readonly DocumentRepository _documentRepository;

        public DocumentService(DocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public async Task StoreDocumentEmbeddingAsync(Document document)
        {
            document.Id = Guid.NewGuid();
            document.CreatedAt = DateTime.UtcNow;
            await _documentRepository.AddDocumentAsync(document);
        }

        public async Task<Document> GetDocumentEmbeddingAsync(Guid id)
        {
            return await _documentRepository.GetDocumentByIdAsync(id);
        }
    }
}
