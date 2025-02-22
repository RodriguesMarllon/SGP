using Domain.Entities.Employees;
using Domain.InterfacesRepositories.Employees;
using Infrastructure.Configuration;
using Infrastructure.Repositories.Abstract;

namespace Infrastructure.Repositories.Employees
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly SGPContext _context;

        public EmployeeRepository(SGPContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(Employee obj)
        {
            _context.Employees.Add(obj); 
            await _context.SaveChangesAsync();
            return obj.Id > 0;
        }
    }
}
