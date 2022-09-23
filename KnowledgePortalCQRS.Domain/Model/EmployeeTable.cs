using System;
using System.Collections.Generic;

namespace KnowledgePortalCQRS.Domain.Entities
{
    public partial class EmployeeTable
    {
        public EmployeeTable()
        {
            FileDetialsTables = new HashSet<FileDetialsTable>();
        }

        public string EmployeeId { get; set; } = null!;
        public string? EmployeeFirstName { get; set; }
        public string? EmployeeLastName { get; set; }
        public string? EmployeeRole { get; set; }
        public string? EmployeeLocation { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string? ManagerId { get; set; }
        public string? EmployeeMailId { get; set; }

        public virtual ICollection<FileDetialsTable> FileDetialsTables { get; set; }
    }
}
