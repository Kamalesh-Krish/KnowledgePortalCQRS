using KnowledgePortalCQRS.Domain.Entities;
using MediatR;

namespace KnowledgePortalCQRS.API.Command
{
    public record UpdateEmployeeCommand(EmployeeTable Employee) : IRequest<>
    
}
