using KnowledgePortalCQRS.Domain.Entities;
using KnowledgePortalCQRS.Domain.Interface;
using KnowledgePortalCQRS.Infrastructure.Entities;

namespace KnowledgePortalCQRS.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly KnowledgePortalContext _knowledgePortalContext;
        public EmployeeRepository(KnowledgePortalContext knowledgePortalContext)
        {
            _knowledgePortalContext = knowledgePortalContext;
        }

        public Task<List<EmployeeTable>> GetAllEmployee() => Task.FromResult(_knowledgePortalContext.EmployeeTables.ToList());
        public Task<List<EmployeeTable>> AddEmployee(EmployeeTable employee)
        {
            _knowledgePortalContext.EmployeeTables.Add(employee);
            _knowledgePortalContext.SaveChanges();
            return Task.FromResult(_knowledgePortalContext.EmployeeTables.ToList());
        }

        public Task DeleteEmployee(string id)
        {
            throw new NotImplementedException();
        }

        

        public Task UpdateEmployee(EmployeeTable employee)
        {
            throw new NotImplementedException();
        }
    }
}
