using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Entities;
using StudentManagement.Interfaces;
using StudentManagement.Services;
using StudentManagement.DTOs;

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
        public async Task<IActionResult> GetStudent()
        {
            return Ok(await _student.GetStudents());
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentDTO studentDto)
        {
            Student student = new Student
            {
                Name = studentDto.Name,
                Subject = studentDto.Subject
            };

            await _student.AddStudent(student);
            return Ok( student);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student =await _student.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student);
            }
        }
    }
}

