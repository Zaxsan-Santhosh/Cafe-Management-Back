using WebApplication1.Entities;
using WebApplication1.IRepos;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            return await employeeRepo.GetAllEmployee();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await employeeRepo.GetEmployeeById(id);
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            return await employeeRepo.CreateEmployee(employee);
        }
        public async Task UpdateEmployee(Employee employee)
        {
            await employeeRepo.UpdateEmployee(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            await employeeRepo.DeleteEmployee(id);
        }
    }
}
