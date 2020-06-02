using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleAppPartitionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Muhammed" , "Essa" , "Hameed" , "Samir" , "Emad"};

            //   IEnumerable<string> names2 = names.Take(4);
            // IEnumerable<string> names3 = names.TakeWhile(x => x.StartsWith("M"));

            /// IEnumerable<string> names4 = names.Skip(3);
            /// 
          //  IEnumerable<string> names3 = (from x in names select x).TakeWhile(x => x.StartsWith("M"));
            IEnumerable<string> names4 = (from x in names select x).Skip(3);
            foreach (var e  in names4)
            {
                Console.WriteLine("names: " + e );
            }

           
        }
    }
}
