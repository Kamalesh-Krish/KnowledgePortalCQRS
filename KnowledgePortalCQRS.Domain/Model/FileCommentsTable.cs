using System;
using System.Collections.Generic;

namespace KnowledgePortalCQRS.Domain.Entities
{
    public partial class FileCommentsTable
    {
        public int? FileId { get; set; }
        public string? FileComments { get; set; }

        public virtual FileDetialsTable? File { get; set; }
    }
}
