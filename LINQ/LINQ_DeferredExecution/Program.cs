﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DeferredExecution
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
            List<Student> listStudents = new List<Student>
            {
                new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };

            IEnumerable<Student> result = from student in listStudents
                                          where student.TotalMarks == 800
                                          select student;
            listStudents.Add(new Student { StudentID = 104, Name = "Tim", TotalMarks = 800 });

            foreach (Student s in result)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            }

            Console.ReadLine();
        }
    }
}
