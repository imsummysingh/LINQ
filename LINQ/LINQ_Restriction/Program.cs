using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Restriction
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lambda Exp

            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //IEnumerable<int> EvenNumbers = Numbers.Where(n => n % 2 == 0);

            //foreach(int num in EvenNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            // Using SQL like syntax
            //IEnumerable<int> evenNumbers = from num in numbers
            //                               where num % 2 == 0
            //                               select num;


            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //IEnumerable<int> evenNumbers = numbers.Where(num => IsEven(num));

            //foreach (int evenNumber in evenNumbers)
            //{
            //    Console.WriteLine(evenNumber);
            //}

            IEnumerable<int> EvenNumbers = Numbers.Select((num, index) => new { Number = num, Index = index }).
                                           Where(x => x.Number % 2 == 0).Select(x => x.Index);

            foreach(int num in EvenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();

        }

        //public static bool IsEven(int number)
        //{
        //    if (number % 2 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
