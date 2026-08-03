using Microsoft.EntityFrameworkCore;
using EmployeeEntity = Employee.Entities.Employee;
namespace EmployeeManage.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // Define your DbSets for your entities here
        // Example:
         public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
