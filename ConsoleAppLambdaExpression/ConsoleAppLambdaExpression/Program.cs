using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            names.Add("Muhammed");
            names.Add("Ahmed");
            names.Add("samir");
            names.Add("Salih");
            names.Add("Saad");

            // x => x +2 
            IEnumerable<string> result = names.Select(x => x);

            foreach(var x in result)
            {
                Console.WriteLine("names: " + x);
            }

          
        }
    }
}
