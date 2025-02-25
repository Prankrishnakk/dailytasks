using WebApplication1.Model;

namespace WebApplication1.Service
{
    public interface IStudentsService
    {
        List<Students> Get();
        public string Add(Students Addstudent);
        public string Update(Students Updatestudent);
        public string Delete(int id);
    }
}
