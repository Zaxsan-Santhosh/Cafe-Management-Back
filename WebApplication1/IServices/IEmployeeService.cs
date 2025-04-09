using WebApplication1.Entities;

namespace WebApplication1.IServices
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployee();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> CreateEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
