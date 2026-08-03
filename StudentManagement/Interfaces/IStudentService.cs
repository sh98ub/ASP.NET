using StudentManagement.Entities;
namespace StudentManagement.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
    }
}
