using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 33,22,33,44,55,66};
            int[] salary = {   };
            // int getFirstNum = ages.First();
            //  int getFirstNum = (from x in ages select x).First();
            // int getFirstNum = (from x in ages select x).First();
            //   int getFirstNum = salary.FirstOrDefault();
            //  int getFirstNum = (from x in salary select x).FirstOrDefault();

            //  int getFirstNum = ages.Last();
            //  int getFirstNum = (from x in ages select x).Last();

            //   int getFirstNum = salary.LastOrDefault();
            //  int getFirstNum = (from x in salary select x).LastOrDefault();

            //  int myIndex1 = ages.ElementAt(1);
            //  int myIndex2 = ages.ElementAt(2);

            int myIndex1 = ages.ElementAtOrDefault(1);
            int myIndex2 = ages.ElementAtOrDefault(2);
            int myIndex3 = ages.ElementAtOrDefault(22);


            Console.WriteLine("First element: " + myIndex1);
            Console.WriteLine("First element: " + myIndex2);
            Console.WriteLine("First element: " + myIndex3);
        }
    }
}
