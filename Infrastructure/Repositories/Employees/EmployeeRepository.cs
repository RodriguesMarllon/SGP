using Domain.Entities.Employees;
using Domain.InterfacesRepositories.Employees;
using Infrastructure.Configuration;
using Infrastructure.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
