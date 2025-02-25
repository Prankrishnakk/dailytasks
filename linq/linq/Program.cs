using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    public int Id;
    public string Name;
    public int Salary;
    public string Department;
    public int Age;

}

class Programs
{
    static void Main()
    {
        List<Employee> employee = new List<Employee>
        {

           new Employee {Id = 1,Name = "mob",Salary= 10001, Age = 23, Department = "IT"},
           new Employee {Id = 2,Name = "tob",Salary= 30001, Age = 44, Department = "HR"},
           new Employee {Id = 3,Name = "kob",Salary= 15000, Age = 25, Department = "Finance"},
           new Employee {Id = 1,Name = "rob",Salary= 40001, Age = 45, Department = "IT"},
           new Employee {Id = 1,Name = "cob",Salary= 20001,Age = 35, Department = "Finance"}
       };

        //display all employees
         var allemployee = employee;


        foreach (var emp in allemployee)
        {
            Console.WriteLine($"{emp.Id}-{emp.Name}-{emp.Department}-{emp.Salary}-{emp.Age}");
        }

        //display age above 30
        var ageabove = employee.Where(x => x.Age > 30);

        foreach (var emp in ageabove) 
        {
            Console.WriteLine($"{emp.Id}-{emp.Name}-{emp.Age}");
        }

        // display descenting order of salary

        var descentingsalary =employee.OrderByDescending(x => x.Salary);
        foreach (var emp in descentingsalary) 
        {
            Console.WriteLine($"{emp.Name}-{emp.Salary}");
        }

        //5.Display Grouped Department
        var groupedDepartment = employee.GroupBy(e => e.Department);
        

        foreach (var group in groupedDepartment)
        {
            Console.WriteLine($"{group.Key}");

            foreach (var em in group)

                Console.WriteLine($"Name:{em.Name} - Department:{em.Department}");

        }

        //heighestsalary
        var highestSalary = employee.OrderByDescending(e => e.Salary).First();

        Console.WriteLine($"Name :{highestSalary.Name} Salary :{highestSalary.Salary}");


        //lowestsalary
        var lowestsalary = employee.OrderBy(e => e.Salary).First();
        Console.WriteLine($"Name:{lowestsalary.Name} Salary:{lowestsalary.Salary}");

        //second heighest salary
        var secondhighestsalary = employee.OrderByDescending(e => e.Salary).Skip(1).First();
        Console.WriteLine($"Name : {secondhighestsalary.Name} second heighest salary{secondhighestsalary.Salary} ");

        //find count
        var count = employee.Count(e => e.Department == "IT");
        {
            Console.WriteLine($"Count in IT = {count}");
        }

        //Take first Three Employees

        var take = employee.Take(3);
        foreach (var em in take)
        {
            Console.WriteLine($"{em.Name}:{em.Salary}");

        }
        // Correct way to sum salaries with even values
        var totalEvenSalary = employee.Where(emp => emp.Salary % 2 == 0).Sum(emp => emp.Salary);
        Console.WriteLine("Total Even Salary: " + totalEvenSalary);
    }
}












