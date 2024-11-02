using System;
using System.Threading.Tasks;
using B2BAppBackend.Models;
using Npgsql;
using Dapper;

namespace B2BAppBackend.Repositories
{
    public class DocumentRepository
    {
        private readonly string _connectionString;

        public DocumentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task AddDocumentAsync(Document document)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var sql = "INSERT INTO Documents (Id, Title, Content, CreatedAt, Embedding) VALUES (@Id, @Title, @Content, @CreatedAt, @Embedding)";
            await connection.ExecuteAsync(sql, document);
        }

        public async Task<Document> GetDocumentByIdAsync(Guid id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var sql = "SELECT * FROM Documents WHERE Id = @Id";
            return await connection.QuerySingleOrDefaultAsync<Document>(sql, new { Id = id });
        }
    }
}
