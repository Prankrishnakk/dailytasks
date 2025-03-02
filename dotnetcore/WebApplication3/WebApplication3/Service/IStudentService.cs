using WebApplication3.Model;

namespace WebApplication3.Service
{
    public interface IStudentService
    {
        List<Student> Get();
        public string Add(Student Addstudent);
        public string Update(Student Updatestudent);
        public string Delete(int id);
        List<Student> SearchByName(string name);
        public bool Login(string username, string password);
    }
}
