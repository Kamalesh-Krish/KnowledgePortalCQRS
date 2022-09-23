using KnowledgePortalCQRS.API.Command;
using KnowledgePortalCQRS.API.Query;
using KnowledgePortalCQRS.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgePortalCQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;   
        }
        [HttpGet]
        public Task<List<EmployeeTable>> GetAllEmployee() => _mediator.Send(new GetAllEmployeeQuery());
       
        [HttpPost]
        public Task<List<EmployeeTable>> AddEmployee(EmployeeTable employee) => _mediator.Send(new AddEmployeeCommand(employee));
       
    }
}
