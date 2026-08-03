using EmployeeEntity = Employee.Entities.Employee;
namespace EmployeeManage.Interfaces
{
    public interface IEmployeeServices
    {
        List<EmployeeEntity> GetEmployees();
        EmployeeEntity? GetEmployeeById(int id);

        EmployeeEntity CreateEmployee(EmployeeEntity employee);

    }

  
}
