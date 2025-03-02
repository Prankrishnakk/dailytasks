using WebApplication2.Model;

namespace WebApplication2.Service
{
    public class StudentService : IStudentService
    {
        public static List<Student> students = new List<Student>
        {
            new Student{Id =1, Name ="pran", Mark =10,Password ="kdjksmll"},
             new Student{Id =2, Name ="habeeb", Mark =20,Password ="kdjksfddll"},
              new Student{Id =3, Name ="ameen", Mark =30,Password ="kdjkdfmll"},
               new Student{Id =4, Name ="anwar", Mark =50,Password ="kdjksffdfll"},

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
            {
                return "Student is Added";
            }
        }
        public string Update(Student Updatestudent)
        {
            var existingstudent = students.FirstOrDefault(i => i.Id == Updatestudent.Id);
            {
                if (existingstudent == null)
                {
                    return "Student not updated";
                }
                existingstudent.Name = Updatestudent.Name;
                existingstudent.Mark = Updatestudent.Mark;
                existingstudent.Password = Updatestudent.Password;
                return "Student is Updated";
            }
        }
        public string Delete(int id)
        {
            var res = students.FirstOrDefault(i => i.Id == id);
            {
                if (res == null)
                {
                    return " Student Not Deleted";
                }
                students.Remove(res);
                return "Student Deleted";
            }
        }
        public List<Student> SearchByName(String name)
        {
            return students.Where(i=>i.Name.Contains(name)).ToList();
        }
        public bool Login(string username, string password) 
        {
            return students.Any(i=>i.Name == username && i.Password == password);
        }

    }
}