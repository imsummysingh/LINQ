using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXample-1

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int smallestNumber = Numbers.Min();
            //int smallestEvenNumber = Numbers.Where(n => n % 2 == 0).Min();

            //int largestNumber = Numbers.Max();
            //int largestEvenNumber = Numbers.Where(n => n % 2 == 0).Max();

            //int sumOfAllNumbers = Numbers.Sum();
            //int sumOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Sum();

            //int countOfAllNumbers = Numbers.Count();
            //int countOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Count();

            //double averageOfAllNumbers = Numbers.Average();
            //double averageOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Average();

            //Console.WriteLine("Smallest Number = " + smallestNumber);
            //Console.WriteLine("Smallest Even Number = " + smallestEvenNumber);

            //Console.WriteLine("Largest Number = " + largestNumber);
            //Console.WriteLine("Largest Even Number = " + largestEvenNumber);

            //Console.WriteLine("Sum of All Numbers = " + sumOfAllNumbers);
            //Console.WriteLine("Sum of All Even Numbers = " + sumOfAllEvenNumbers);

            //Console.WriteLine("Count of All Numbers = " + countOfAllNumbers);
            //Console.WriteLine("Count of All Even Numbers = " + countOfAllEvenNumbers);

            //Console.WriteLine("Average of All Numbers = " + averageOfAllNumbers);
            //Console.WriteLine("Average of All Even Numbers = " + averageOfAllEvenNumbers);


            //Example-2

            //string[] Countries = { "India", "USA", "UK" };
            //int minCount = Countries.Min(x => x.Length);
            //int maxCount = Countries.Max(x => x.Length);

            //Console.WriteLine
            //       ("The shortest country name has {0} characters in its name", minCount);
            //Console.WriteLine
            //       ("The longest country name has {0} characters in its name", maxCount);


            //Example-3 Aggregate() Function

            //string[] Countries = { "India", "USA", "UK","Canada","Pakistan"};

            //string result = Countries.Aggregate((a, b) => a + " , " + b);
            //Console.WriteLine(result);


            //Example-4

            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = Numbers.Aggregate((a, b) => a + b);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
