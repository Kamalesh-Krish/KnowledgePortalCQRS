using KnowledgePortalCQRS.API.Command;
using KnowledgePortalCQRS.Domain.Entities;
using KnowledgePortalCQRS.Domain.Interface;
using MediatR;

namespace KnowledgePortalCQRS.API.Handler
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, List<EmployeeTable>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public AddEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Task<List<EmployeeTable>> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
            => _employeeRepository.AddEmployee(request.Employee);

    }
}
