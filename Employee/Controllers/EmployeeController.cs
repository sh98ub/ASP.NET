using Employee.Entities;
using EmployeeManage.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeManage.Interfaces;
using EmployeeEntity = Employee.Entities.Employee;

namespace EmployeeManage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeService;
    public    EmployeeController(IEmployeeServices employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult GetEmployees()
        {
             var employees = _employeeService.GetEmployees();

            return Ok(employees);

        }
        [HttpGet("age")]
        public IActionResult getAge()
        {
            return Ok(13);
        }
        [HttpGet("id")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById( id);
            if(employee != null)
            {
                return Ok(employee);
            }



            return NotFound();

        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeEntity employee)
        {
            var createdEmployee = _employeeService.CreateEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = createdEmployee.Id }, createdEmployee);
        }
    }
}
