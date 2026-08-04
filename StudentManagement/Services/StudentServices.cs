using StudentManagement.Entities;
using StudentManagement.Interfaces;
using StudentManagement.Data;
using Microsoft.EntityFrameworkCore;
namespace StudentManagement.Services
{
    public class StudentServices : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentServices(IStudentRepository repository)
        {
            _repository = repository;

        }

        public async Task<List<Student>> GetStudents()
        {
            return await _repository.GetAllStudents();

        }

        public async Task<Student> AddStudent(Student student)
        {
            await _repository.AddStudent(student);
            return student;
        }

      
            public async Task<Student?> GetStudentById(int id)
        {
            return await _repository.GetStudentById(id);
        }
    }
}
    
 
