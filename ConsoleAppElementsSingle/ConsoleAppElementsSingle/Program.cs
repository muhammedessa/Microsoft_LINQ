using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppElementsSingle
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> emp = new List<Employee>()
            {
                new Employee(){ FirstName = "Muhammed" , LastName = "Essa" ,age=36},
                new Employee(){ FirstName = "Ahmed" , LastName = "Hameed" ,age=22},
                new Employee(){ FirstName = "Hassan" , LastName = "Ali" ,age=33},
                new Employee(){ FirstName = "Omer" , LastName = "yousif" ,age=44},
                new Employee(){ FirstName = "Salim" , LastName = "taha" ,age=55},
            };

            //   var employee = emp.Single(x => x.FirstName == "Hassan");
            //var employee = emp.SingleOrDefault(x => x.FirstName == "Hassan");
            //string name = employee.FirstName;


            //int[] ages = { 22, 33, 44, 55, 66 };
            //int[] salary = { };

            //var check1 = ages.DefaultIfEmpty();
            //var check2 = salary.DefaultIfEmpty();

            //foreach(var x in check1)
            //{
            //    Console.WriteLine("check1: " + x);
            //}

            //foreach (var x in check2)
            //{
            //    Console.WriteLine("check2: " + x);
            //}

            string[] names = {"Muhammed", "Essa", "Hameed", "Ali", "omer", "Khalid" };
            List<string> myList = names.ToList();
          //  string[] myNames = names.ToArray();
            string[] myNames = (from i in names select i ).ToArray();

            foreach (var x in myNames)
            {
                Console.WriteLine("name: " + x);
            }

        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }
}
