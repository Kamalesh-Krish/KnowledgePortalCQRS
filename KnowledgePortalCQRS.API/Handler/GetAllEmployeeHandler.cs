using KnowledgePortalCQRS.API.Query;
using KnowledgePortalCQRS.Domain.Entities;
using KnowledgePortalCQRS.Domain.Interface;
using MediatR;

namespace KnowledgePortalCQRS.API.Handler
{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<EmployeeTable>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetAllEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Task<List<EmployeeTable>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
            => _employeeRepository.GetAllEmployee();

    }
}
