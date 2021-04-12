using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SetOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //distinct
            //string[] countries = { "USA", "usa", "INDIA", "UK", "UK" };

            //var result = countries.Distinct();

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v);
            //}

            //for case comparison
            //var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v);
            //}


            //Union
            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = { 1, 3, 6, 7, 8 };

            //var result = numbers1.Union(numbers2);

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v);
            //}

            //List<Employee> list1 = new List<Employee>()
            //{
            //    new Employee { ID = 101, Name = "Mike"},
            //    new Employee { ID = 102, Name = "Susy"},
            //    new Employee { ID = 103, Name = "Mary"}
            //};

            //List<Employee> list2 = new List<Employee>()
            //{
            //    new Employee { ID = 101, Name = "Mike"},
            //    new Employee { ID = 104, Name = "John"}
            //};

            //var result = list1.Union(list2);

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v.ID + "\t" + v.Name);
            //}

            //Intersect
            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = { 1, 3, 6, 7, 8 };

            //var result = numbers1.Intersect(numbers2);

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v);
            //}

            //Except
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 1, 3, 6, 7, 8 };

            var result = numbers1.Except(numbers2);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();


        }
    }
}
