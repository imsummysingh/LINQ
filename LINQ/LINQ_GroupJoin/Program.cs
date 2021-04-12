using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeByDepartment = Department.GetAllDepartments().GroupJoin(Employee.GetAllEmployees(), d => d.ID, e => e.DepartmentID, (department, employee) => new { Department = department, Employees = employee });

            foreach(var department in employeeByDepartment)
            {
                Console.WriteLine(department.Department.Name);
                foreach(var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine();
            }


            //SQL SYNTAX
            //var employeesByDepartment = from d in Department.GetAllDepartments()
            //                            join e in Employee.GetAllEmployees()
            //                            on d.ID equals e.DepartmentID into eGroup
            //                            select new
            //                            {
            //                                Department = d,
            //                                Employees = eGroup
            //                            };

            Console.ReadLine();
        }
    }
}
