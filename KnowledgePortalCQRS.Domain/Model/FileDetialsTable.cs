using System;
using System.Collections.Generic;

namespace KnowledgePortalCQRS.Domain.Entities
{
    public partial class FileDetialsTable
    {
        public int FileId { get; set; }
        public string? FileName { get; set; }
        public string? EmployeeId { get; set; }
        public double? FileAverage { get; set; }

        public virtual EmployeeTable? Employee { get; set; }
    }
}
