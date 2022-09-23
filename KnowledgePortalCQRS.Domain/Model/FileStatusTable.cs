using System;
using System.Collections.Generic;

namespace KnowledgePortalCQRS.Domain.Entities
{
    public partial class FileStatusTable
    {
        public int? FileId { get; set; }
        public string? FileStatus { get; set; }
        public string? EmployeeId { get; set; }

        public virtual EmployeeTable? Employee { get; set; }
        public virtual FileDetialsTable? File { get; set; }
    }
}
