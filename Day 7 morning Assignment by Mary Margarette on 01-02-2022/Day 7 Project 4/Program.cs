using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_4
{
    //Author: Mary Margaret
    /*Create Employee Class
    * create object and initialise with 5 values and use for loop,foreach loop,lambda expression*/
    class Employee //class declaration
    {
        //variables declaration
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation
            Employee[] emp = new Employee[] 
            {
                //initialising object with values
                new Employee() { id = 1, name = "Margaret", salary = 5000},
                new Employee() { id = 2, name = "Rajendra", salary = 6000},
                new Employee() { id = 3, name = "Tejaswi",salary = 7000},
                new Employee() { id = 4, name = "Samuel", salary = 8000},
                new Employee() { id = 5, name = "Chandana", salary = 9000}
            };
            //for loop
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"id={emp[i].id},name={emp[i].name},salary={emp[i].salary}");
            }
            //foreach loop
            foreach (var e in emp)
            {
                Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
            }
            //lambda expression
            emp.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));
            Console.ReadLine();
        }
    
    }
}
