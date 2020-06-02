using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 12,13,14,10,1,2,3,55};
            int minNum = numbers.Min();
            int maxNum = numbers.Max();
            int sumNum = numbers.Sum();
            int countNums = numbers.Count();

            Console.WriteLine("Min: " + minNum);
            Console.WriteLine("Max: " + maxNum);
            Console.WriteLine("Sum: " + sumNum);
            Console.WriteLine("Count: " + countNums);
        }
    }
}
