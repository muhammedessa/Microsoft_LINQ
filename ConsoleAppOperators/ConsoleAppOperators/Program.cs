using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>() {
     new Employee() {id= 1 ,FirstName = "Muhammed" , LastName="Essa",Age = 36 , 
         Gender="Male" , Department = new List<string>{ "IT","Software developer"}},
     new Employee() { id= 2 ,FirstName = "Ahmed" , LastName="Fahad",Age = 22 ,
         Gender="Male" , Department = new List<string>{ "HR","Accounting"}},
     new Employee() {id= 3 ,FirstName = "Faisal" , LastName="Taha",Age = 34 ,
         Gender="Male" , Department = new List<string>{ "Sales","Marketing"}},
     new Employee() {id= 4 ,FirstName = "Samir" , LastName="Ahmed",Age = 37 ,
         Gender="Male" , Department = new List<string>{ "RF","Cell Planning"}},
     new Employee() {id= 5 ,FirstName = "Hameed" , LastName="Waleed",Age = 50 ,
         Gender="Male" , Department = new List<string>{ "RF","Optimization"}}
            };


            var employees = emp.OrderBy(x => x.FirstName).ThenByDescending(x => x.id);
            foreach (var e in employees)
            {
                Console.WriteLine("Employee First Name: " + e.FirstName +
                                     " Employee id: " + e.id);
            }

            //var employees = emp.OrderByDescending(x => x.FirstName);
            //foreach (var e in employees)
            //{
            //    Console.WriteLine("Employee First Name: " + e.FirstName);
            //}

            //var employees = emp.OrderBy(x => x.FirstName).ThenBy(x => x.id);
            //foreach (var e in employees)
            //{
            //    Console.WriteLine("Employee First Name: " + e.FirstName +
            //                         " Employee id: " + e.id);
            //}


        }
    }

    public class Employee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public List<string> Department { get; set; }
    }
}
