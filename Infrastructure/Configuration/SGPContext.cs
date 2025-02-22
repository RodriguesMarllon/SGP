using Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class SGPContext : DbContext
    {
        public SGPContext(DbContextOptions<SGPContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
