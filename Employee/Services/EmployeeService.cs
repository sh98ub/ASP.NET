using EmployeeManage.Data;
using EmployeeManage.Interfaces;
using EmployeeEntity = Employee.Entities.Employee;
namespace EmployeeManage.Services
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<EmployeeEntity> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public EmployeeEntity? GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public EmployeeEntity CreateEmployee(EmployeeEntity employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

    }
}



 