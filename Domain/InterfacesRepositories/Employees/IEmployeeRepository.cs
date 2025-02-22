using Domain.Entities.Employees;

namespace Domain.InterfacesRepositories.Employees
{
    public interface IEmployeeRepository
    {
        Task<bool> Add(Employee obj);
        Task<List<Employee>> GetAll();
    }
}
