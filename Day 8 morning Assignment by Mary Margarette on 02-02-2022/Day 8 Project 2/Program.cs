using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Project_2
{
    //Author : Mary Margaret
    //Create Class Employee with 3 variables
    //and using for loop, foreach loop, lambda expression and LINQ query find out Employess who earn more than 5000
    class Employee
    {
        public int id;
        public string name;
        public int salary;

    }
    internal class Program
    {
   
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { id = 202, name = "Ramya", salary = 8000 },
                new Employee() { id = 203, name = "Raju", salary = 6500 },
                new Employee() { id = 204, name = "Raghav", salary = 3000 },
                new Employee() { id = 205, name = "Ramayya", salary = 5500 },
                new Employee() { id = 206, name = "Rajesh", salary = 2000 }
            };
            //for loop for whose salary >5000
            for (int i=0; i < employees.Count; i++)
            {
                if(employees[i].salary > 5000)
                {
                    Console.WriteLine(employees[i].name);
                }
            }

            //foreach loop for whose salary >5000
            foreach(var e in employees)
            {
                if(e.salary>5000)
                    Console.WriteLine(e.name);
            }

            //lambda expression for whose salary >5000
            employees.Where(e => e.salary > 5000).ToList().ForEach(e => Console.WriteLine(e.name));


            //LINQ query to print even numbers from list 

            var result = from e in employees
                         where e.salary > 5000
                         select e.name;

            result.ToList().ForEach(d => Console.WriteLine(d));

            Console.ReadLine();


        }
    }
}
