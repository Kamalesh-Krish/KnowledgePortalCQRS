using KnowledgePortalCQRS.Domain.Entities;

namespace KnowledgePortalCQRS.Domain.Interface
{
    public interface IEmployeeRepository
    {
        public Task<List<EmployeeTable>> GetAllEmployee();
        public Task<List<EmployeeTable>> AddEmployee(EmployeeTable employee);
        public Task UpdateEmployee(EmployeeTable employee);
        public Task DeleteEmployee(string id);
    }
}
