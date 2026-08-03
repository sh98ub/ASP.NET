using StudentManagement.Entities;
namespace StudentManagement.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetStudents();

        public Student AddStudent(Student student);

    }
}
