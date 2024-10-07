using ems_api.Models;
using Microsoft.EntityFrameworkCore;

namespace ems_api.DataBase
{
    public class EmpDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options) { }
    }
}
