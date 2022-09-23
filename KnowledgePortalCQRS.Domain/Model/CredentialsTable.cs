using System;
using System.Collections.Generic;

namespace KnowledgePortalCQRS.Domain.Entities
{
    public partial class CredentialsTable
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }

        public virtual EmployeeTable? User { get; set; }
    }
}
