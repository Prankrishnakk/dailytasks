using WebApplication2.Model;

namespace WebApplication2.Service
{
    public interface IStudentService
    {
        List<Student> Get();
        public string Add(Student Addstudent);
        public string Update(Student Updatestudent);
        public string Delete(int Id);
        
        List<Student> SearchByName(String name);

        bool Login(string username, string password);
    }
}
