using KnowledgePortalCQRS.Domain.Entities;
using MediatR;

namespace KnowledgePortalCQRS.API.Query
{
    public record GetAllEmployeeQuery : IRequest<List<EmployeeTable>>;

}
