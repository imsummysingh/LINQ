using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_LeftOuterJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID into eGroup
                         from d in eGroup.DefaultIfEmpty()
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d == null ? "No Department" : d.Name
                         };

            foreach (var v in result)
            {
                Console.WriteLine(v.EmployeeName + "\t" + v.DepartmentName);
            }


            //Lambda exp
            //var result = Employee.GetAllEmployees()
            //            .GroupJoin(Department.GetAllDepartments(),
            //                    e => e.DepartmentID,
            //                    d => d.ID,
            //                    (emp, depts) => new { emp, depts })
            //            .SelectMany(z => z.depts.DefaultIfEmpty(),
            //                    (a, b) => new
            //                    {
            //                        EmployeeName = a.emp.Name,
            //                        DepartmentName = b == null ? "No Department" : b.Name
            //                    });

            //foreach (var v in result)
            //{
            //    Console.WriteLine(" " + v.EmployeeName + "\t" + v.DepartmentName);
            //}

            Console.ReadLine();
        }
    }
}
