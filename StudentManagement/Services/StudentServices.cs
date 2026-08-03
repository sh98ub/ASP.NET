using StudentManagement.Entities;
using StudentManagement.Interfaces;
using StudentManagement.Data;
namespace StudentManagement.Services
{
    public class StudentServices:IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentServices(StudentDbContext context)
        {
            _context = context;
        }

        public List<Student> GetStudents( )
        {
            return _context.Students.ToList();
            
        }
    }
}
