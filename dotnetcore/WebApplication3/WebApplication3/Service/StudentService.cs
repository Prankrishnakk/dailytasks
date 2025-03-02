using WebApplication3.Model;

namespace WebApplication3.Service
{
    public class StudentService : IStudentService
    {
        public static List<Student> students = new List<Student>
        {
            new Student{Id =1,Name="pran",Password="pas3232",Mark=200},
            new Student{Id =2,Name="krishna",Password="pas3333",Mark=100},
             new Student{Id =1,Name="pranav",Password="pas3232",Mark=200},
            new Student{Id =2,Name="krishh",Password="pas3333",Mark=100},
        };

        public List<Student> Get() 
        {
            return students;
        }
        public string Add(Student Addstudent) 
        {
            if (Addstudent == null) 
            {
                return "No Student Added";
            }
            students.Add(Addstudent);
            return "Student Added";
        }
        public string Update(Student Updatestudent)
        {
            var existingstudent = students.FirstOrDefault(i=>i.Id == Updatestudent.Id);
            if (existingstudent == null) 
            {
                return "Not Updated";
            }
             existingstudent.Name = Updatestudent.Name;
            existingstudent.Password = Updatestudent.Password;
            existingstudent.Mark = Updatestudent.Mark;
            return "Updated";

        }
        public string Delete(int id) 
        {
            var res= students.FirstOrDefault(i=>i.Id==id);
            if (res == null) 
            {
                return "Student not Deleted";
            }
            students.Remove(res);
            return "Student Deleted";
        }
        public List<Student> SearchByName(string name)
        {
            return students.Where(i => i.Name.Contains(name)).ToList();
        }
        public bool Login(string username, string password)
        {
            return students.Any(i => i.Name == username && i.Password == password);
        }

    }
}
