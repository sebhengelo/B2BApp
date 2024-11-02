using System;

namespace B2BAppBackend.Models
{
    public class Document
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public float[] Embedding { get; set; }
    }
}
