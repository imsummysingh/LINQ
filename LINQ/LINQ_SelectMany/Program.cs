using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambda exp
            //IEnumerable<string> allSubjects = Student.GetAllStudetns().SelectMany(s => s.Subjects);
            //foreach (string subject in allSubjects)
            //{
            //    Console.WriteLine(subject);
            //}


            //SQL SYNTAX
            //IEnumerable<string> allSubjects = from student in Student.GetAllStudetns()
            //                                  from subject in student.Subjects
            //                                  select subject;

            //foreach (string subject in allSubjects)
            //{
            //    Console.WriteLine(subject);
            //}


            //string[] stringArray =
            //                        {
            //                            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            //                            "0123456789"
            //                        };

            //IEnumerable<char> result = stringArray.SelectMany(s => s);

            //foreach (char c in result)
            //{
            //    Console.WriteLine(c);
            //}



            //string[] stringArray =
            //                        {
            //                            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            //                            "0123456789"
            //                        };

            //IEnumerable<char> result = from s in stringArray
            //                           from c in s
            //                           select c;

            //foreach (char c in result)
            //{
            //    Console.WriteLine(c);
            //}


            //select distinct sub
            //IEnumerable<string> allSubjects = Student.GetAllStudetns()
            //                                                       .SelectMany(s => s.Subjects).Distinct();
            //foreach (string subject in allSubjects)
            //{
            //    Console.WriteLine(subject);
            //}

            //sql syntax
            //IEnumerable<string> allSubjects = (from student in Student.GetAllStudetns()
            //                                   from subject in student.Subjects
            //                                   select subject).Distinct();

            //foreach (string subject in allSubjects)
            //{
            //    Console.WriteLine(subject);
            //}


            //Selects student name along with all the subjects
            var result = Student.GetAllStudetns().SelectMany(s => s.Subjects, (student, subject) => new { student = student.Name, subject = subject });

            foreach (var v in result)
            {
                Console.WriteLine(v.student + " - " + v.subject);
            }
            Console.ReadLine();
        }
    }
}
