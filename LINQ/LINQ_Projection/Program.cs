using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Projection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retrieve EmployeeID
            //IEnumerable<int> employeeID = Employee.GetAllEmployees().Select(emp => emp.EmployeeID);
            //foreach (int id in employeeID)
            //{
            //    Console.WriteLine(id);
            //}

            //var employeeID = Employee.GetAllEmployees().Select(emp => emp.EmployeeID);
            //foreach (int id in employeeID)
            //{
            //    Console.WriteLine(id);
            //}

            //FirstName and Gender
            //var result = Employee.GetAllEmployees().Select(emp => new { Name = emp.FirstName, Gender = emp.Gender });
            //foreach(var v in result)
            //{
            //    Console.WriteLine(v.Name + " - " + v.Gender);
            //}

            //FirstName, AnnualSalay and Bonus
            var result = Employee.GetAllEmployees()
                .Where(emp => emp.AnnualSalary > 50000)
                .Select(emp => new
                {
                    Name = emp.FirstName,
                    Salary = emp.AnnualSalary,
                    Bonus = emp.AnnualSalary * .1
                });

            foreach (var v in result)
            {
                Console.WriteLine(v.Name + " : " + v.Salary + " - " + v.Bonus);
            }

            Console.ReadLine();
        }
    }
}
