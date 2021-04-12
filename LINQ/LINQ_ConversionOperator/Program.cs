using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConversionOperator
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //To List
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //List<int> result = numbers.ToList();

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //To Array
            //List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

            //string[] result = (from country in countries
            //                   orderby country ascending
            //                   select country).ToArray();

            //foreach (string str in result)
            //{
            //    Console.WriteLine(str);
            //}

            //To Dictionary
            //List<Student> listStudents = new List<Student>
            //{
            //    new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
            //    new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
            //    new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            //};

            //Dictionary<int, string> result = listStudents.ToDictionary(x => x.StudentID, x => x.Name);

            //foreach (KeyValuePair<int, string> kvp in result)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}

            //List<Student> listStudents = new List<Student>
            //{
            //    new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
            //    new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
            //    new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            //};
            //Dictionary<int, Student> result = listStudents.ToDictionary(x => x.StudentID);
            //foreach(KeyValuePair<int,Student> kvp in result)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value.Name + " " + kvp.Value.TotalMarks);
            //}


            //cast operator
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //// The following item causes an exception
            //// list.Add("ABC");

            //IEnumerable<int> result = list.Cast<int>();

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}



            //ofType
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add("4");
            //list.Add("ABC");

            //IEnumerable<int> result = list.OfType<int>();

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}



            Console.ReadLine();
        }
    }
}
