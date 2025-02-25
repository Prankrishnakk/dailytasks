using WebApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Service
{
    public class Student : IStudentsService
    {
        private static List<Students> students = new List<Students>
        {
            new Students { Id = 1, Name = "pran", Mark = 10 },
            new Students { Id = 2, Name = "krishna", Mark = 20 },
        };

        public List<Students> Get()
        {
            try
            {
                return students;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"An error occurred while retrieving students: {ex.Message}");
                return new List<Students>(); 
            }
        }

        public string Add(Students addStudent)
        {
            try
            {
                if (addStudent == null)
                {
                    return "No student added";
                }
                students.Add(addStudent);
                return "Student added";
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred while adding a student: {ex.Message}");
                return "An error occurred while adding the student";
            }
        }

        public string Update(Students updateStudent)
        {
            try
            {
                var existingStudent = students.FirstOrDefault(i => i.Id == updateStudent.Id);
                if (existingStudent == null)
                {
                    return "Student not found";
                }
                existingStudent.Name = updateStudent.Name;
                existingStudent.Mark = updateStudent.Mark;
                return "Update successful";
            }
            catch (Exception ex)
            {
              
                Console.WriteLine($"An error occurred while updating a student: {ex.Message}");
                return "An error occurred while updating the student";
            }
        }

        public string Delete(int id)
        {
            try
            {
                var studentToRemove = students.FirstOrDefault(i => i.Id == id);
                if (studentToRemove == null)
                {
                    return "Student not found";
                }
                students.Remove(studentToRemove);
                return "Deleted";
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"An error occurred while deleting a student: {ex.Message}");
                return "An error occurred while deleting the student";
            }
        }
    }
}

