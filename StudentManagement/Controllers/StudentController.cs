using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Entities;
using StudentManagement.Services;
using StudentManagement.Interfaces;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _student;

        public StudentController(IStudentService student)
        {
            _student = student;
        }

        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(_student.GetStudents());
        }

    }
}
