using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_5
{
    //Author: Mary Margaret
    /*Create Employee Class
    * create object and initialise with 5 values
    * and write code to print employees who is getting salary >=5000
    * using for loop,foreach loop, lambda expression*/
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
            //object declaration
            Employee[] emp = new Employee[]
            {
                new Employee() { id = 1, name = "Margaret", salary = 8500},
                new Employee() { id = 2, name = "Raj", salary = 6500},
                new Employee() { id = 3, name = "Teja",salary = 5500},
                new Employee() { id = 4, name = "Samuel", salary = 2200},
                new Employee() { id = 5, name = "David", salary = 6300}
            };
            //for loop
            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].salary >= 5000)
                    Console.WriteLine($"id={emp[i].id},name={emp[i].name},salary={emp[i].salary}");
            }
            //foreach loop
            foreach (var e in emp)
            {
                if (e.salary >= 5000)
                    Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
            }
            //lambda expression
            emp.ToList().Where(e => e.salary >= 5000).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));
            Console.ReadLine();
        }
    }
}
