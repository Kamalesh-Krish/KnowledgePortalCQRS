using System;
using System.Collections.Generic;

namespace KnowledgePortalCQRS.Domain.Entities
{
    public partial class FileRatingTable
    {
        public int? FileId { get; set; }
        public string? EmployeeId { get; set; }
        public double? FileRating { get; set; }
        public string? RatingStatus { get; set; }

        public virtual EmployeeTable? Employee { get; set; }
        public virtual FileDetialsTable? File { get; set; }
    }
}
