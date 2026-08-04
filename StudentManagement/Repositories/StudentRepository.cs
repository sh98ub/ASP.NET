using StudentManagement.Entities;
using StudentManagement.Interfaces;
using StudentManagement.Data;
using Microsoft.EntityFrameworkCore;
namespace StudentManagement.Repositories
{
    public class StudentRepository :IStudentRepository
{
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }
        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);

            await _context.SaveChangesAsync();

            return student;
        }
        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }
        public async Task<Student?> GetStudentById(int id)
        {
            return await _context.Students.FindAsync(id);
        }
    }
}
