using StudentManagement.Entities;
namespace StudentManagement.Interfaces
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudents();

        public Task<Student> AddStudent(Student student);

        public Task<Student?> GetStudentById(int id);
    }
}
