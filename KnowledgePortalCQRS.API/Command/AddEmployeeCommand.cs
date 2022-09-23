using KnowledgePortalCQRS.Domain.Entities;
using MediatR;

namespace KnowledgePortalCQRS.API.Command
{
    public record AddEmployeeCommand (EmployeeTable Employee) : IRequest<List<EmployeeTable>>;
    
}
