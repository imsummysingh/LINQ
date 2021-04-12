using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CrossJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cross Join Employees collection with Departments collections.
            //var result = from e in Employee.GetAllEmployees()
            //             from d in Department.GetAllDepartments()
            //             select new { e, d };

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            //}



            // Cross Join Departments collections with Employees collection
            //var result = from d in Department.GetAllDepartments()
            //             from e in Employee.GetAllEmployees()
            //             select new { e, d };

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            //}


            //using SelectMany in lambda exp
            //var result = Employee.GetAllEmployees()
            //            .SelectMany(e => Department.GetAllDepartments(), (e, d) => new { e, d });

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            //}


            //Implementing cross join using Join()
            var result = Employee.GetAllEmployees()
                                     .Join(Department.GetAllDepartments(),
                                               e => true,
                                               d => true,
                                               (e, d) => new { e, d });

            foreach (var v in result)
            {
                Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            }

            Console.ReadLine();
        }
    }
}
