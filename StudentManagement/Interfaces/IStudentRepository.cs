using StudentManagement.Entities;

namespace StudentManagement.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudents();

        Task<Student?> GetStudentById(int id);

        Task<Student> AddStudent(Student student);
    }
}
