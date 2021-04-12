using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Employee Count By Department
            var employeeGroup = from employee in Employee.GetAllEmployees()
                                group employee by employee.Department;

            foreach(var group in employeeGroup)
            {
                Console.WriteLine("{0}-{1}", group.Key, group.Count());
            }

            //Get Employee Count By Department and also each employee and department name
            //var employeeGroup = from employee in Employee.GetAllEmployees()
            //                    group employee by employee.Department;

            //foreach (var group in employeeGroup)
            //{
            //    Console.WriteLine("{0} - {1}", group.Key, group.Count());
            //    Console.WriteLine("----------");
            //    foreach (var employee in group)
            //    {
            //        Console.WriteLine(employee.Name + "\t" + employee.Department);
            //    }
            //    Console.WriteLine(); Console.WriteLine();
            //}

            //Get Employee Count By Department and also each employee and department name. 
            //Data should be sorted first by Department in ascending order and then by Employee Name in ascending order.
            //var employeeGroup = from employee in Employee.GetAllEmployees()
            //                    group employee by employee.Department into eGroup
            //                    orderby eGroup.Key
            //                    select new
            //                    {
            //                        Key = eGroup.Key,
            //                        Employees = eGroup.OrderBy(x => x.Name)
            //                    };

            //foreach (var group in employeeGroup)
            //{
            //    Console.WriteLine("{0} - {1}", group.Key, group.Employees.Count());
            //    Console.WriteLine("----------");
            //    foreach (var employee in group.Employees)
            //    {
            //        Console.WriteLine(employee.Name + "\t" + employee.Department);
            //    }
            //    Console.WriteLine(); Console.WriteLine();
            //}


            //GROUP BY USING MULTIPLE KEY
            //var employeeGroups = Employee.GetAllEmployees()
            //                            .GroupBy(x => new { x.Department, x.Gender })
            //                            .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
            //                            .Select(g => new
            //                            {
            //                                Dept = g.Key.Department,
            //                                Gender = g.Key.Gender,
            //                                Employees = g.OrderBy(x => x.Name)
            //                            });

            //foreach (var group in employeeGroups)
            //{
            //    Console.WriteLine("{0} department {1} employees count = {2}",
            //        group.Dept, group.Gender, group.Employees.Count());


            //    Console.WriteLine("--------------------------------------------");
            //    foreach (var employee in group.Employees)
            //    {
            //        Console.WriteLine(employee.Name + "\t" + employee.Gender
            //            + "\t" + employee.Department);
            //    }
            //    Console.WriteLine(); Console.WriteLine();
            //}


            //SQL SYNTAX
            //var employeeGroups = from employee in Employee.GetAllEmployees()
            //                     group employee by new
            //                     {
            //                         employee.Department,
            //                         employee.Gender
            //                     } into eGroup
            //                     orderby eGroup.Key.Department ascending,
            //                                   eGroup.Key.Gender ascending
            //                     select new
            //                     {
            //                         Dept = eGroup.Key.Department,
            //                         Gender = eGroup.Key.Gender,
            //                         Employees = eGroup.OrderBy(x => x.Name)
            //                     };


            Console.ReadLine();
        }
    }
}
