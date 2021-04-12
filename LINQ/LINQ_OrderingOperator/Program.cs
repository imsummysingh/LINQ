using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OrderingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort Students by Name in ascending order
            //IEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.Name);
            //foreach(Student std in result)
            //{
            //    Console.WriteLine(std.Name);
            //}

            //Example 2: Rewrite Example 1 using SQL like syntax
            //IEnumerable<Student> result = from student in Student.GetAllStudents()
            //                  orderby student.Name
            //                  select student;

            //foreach (Student student in result)
            //{
            //    Console.WriteLine(student.Name);
            //}

            //Sort Students by Name in descending order
            //IEnumerable<Student> result = Student.GetAllStudents().OrderByDescending(s => s.Name);
            //foreach (Student student in result)
            //{
            //    Console.WriteLine(student.Name);
            //}

            //Rewrite Example 3 using SQL like syntax
            //IEnumerable<Student> result = from student in Student.GetAllStudents()
            //                  orderby student.Name descending
            //                  select student;

            //foreach (Student student in result)
            //{
            //    Console.WriteLine(student.Name);
            //}

            //Then By
            //IEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenBy(s => s.StudentID);
            //foreach (Student student in result)
            //{
            //    Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
            //}


            //SQL Syntax of Then By
            //IEnumerable<Student> result = from student in Student.GetAllStudents()
            //                              orderby student.TotalMarks, student.Name, student.StudentID
            //                              select student;
            //foreach (Student student in result)
            //{
            //    Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
            //}

            IEnumerable<Student> students = Student.GetAllStudents();

            Console.WriteLine("Before calling Reverse");
            foreach (Student s in students)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            }

            Console.WriteLine();
            IEnumerable<Student> result = students.Reverse();

            Console.WriteLine("After calling Reverse");
            foreach (Student s in result)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            }


            Console.ReadLine();
        }
    }
}
