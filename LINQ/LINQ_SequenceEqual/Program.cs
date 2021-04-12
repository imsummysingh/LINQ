using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SequenceEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] countries1 = { "USA", "India", "UK" };
            //string[] countries2 = { "USA", "India", "UK" };

            //var result = countries1.SequenceEqual(countries2);

            //Console.WriteLine("Are Equal = " + result);


            //If we want the comparison to be case-insensitive, 
            //then use the other overloaded version of SequenceEqual() method to which we can pass an alternate comparer.
            //string[] countries1 = { "USA", "INDIA", "UK" };
            //string[] countries2 = { "usa", "india", "uk" };

            //var result = countries1.SequenceEqual(countries2, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("Are Equal = " + result);



            //OrderBy() 
            //string[] countries1 = { "USA", "INDIA", "UK" };
            //string[] countries2 = { "UK", "INDIA", "USA" };

            //var result = countries1.OrderBy(c => c).SequenceEqual(countries2.OrderBy(c => c));

            //Console.WriteLine("Are Equal = " + result);




        }
    }
}
