using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Entities;
using StudentManagement.Interfaces;
using StudentManagement.Services;

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
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            //student.Id= _student.GetStudents().Count() + 1;
            _student.AddStudent(student);
            return Ok(student);
        }

    }
}
