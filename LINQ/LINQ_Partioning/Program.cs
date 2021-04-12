using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Partioning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            //Take first 3 country
            //IEnumerable<string> result = countries.Take(3);
            //foreach(string country in result)
            //{
            //    Console.WriteLine(country);
            //}

            //SQL SYNTAX
            //IEnumerable<string> result = (from country in countries
            //                              select country).Take(3);

            //foreach (string country in result)
            //{
            //    Console.WriteLine(country);
            //}

            //skip first 3 country
            //IEnumerable<string> result = countries.Skip(3);

            //foreach (string country in result)
            //{
            //    Console.WriteLine(country);
            //}

            //Return countries starting from the beginning of the array until a country name is hit that does not have length greater than 2 characters.
            //IEnumerable<string> result = countries.TakeWhile(s => s.Length > 2);

            //foreach (string country in result)
            //{
            //    Console.WriteLine(country);
            //}


            //Skip elements starting from the beginning of the array, until a country name is hit that does not have length greater than 2 characters, and then return the remaining elements.
            //string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            //IEnumerable<string> result = countries.SkipWhile(s => s.Length > 2);

            //foreach (string country in result)
            //{
            //    Console.WriteLine(country);
            //}


            Console.ReadLine();
        }
    }
}
