﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            //concat
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 1, 4, 5 };

            var result = numbers1.Concat(numbers2);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();
        }
    }
}
