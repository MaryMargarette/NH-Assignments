using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day7Project1
    {
        //Author: Mary Margaret
        /*Purpose:Create Employee class with 3 variables and 2 method */
        class Employee
        {
            // variable declaration
            private int id;
            private string name;
            private int salary;
            //method declaration
            public void ReadEmployee() 
            {
                Console.WriteLine("Enter id:");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter salary:");
                salary = Convert.ToInt32(Console.ReadLine());
            }
            public void PrintEmployee() 
            {
                Console.WriteLine($"id={id},name={name},salary={salary}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                // object creation
                Employee e = new Employee(); //e is object of Employee class
                                             
                e.ReadEmployee();
                e.PrintEmployee();
                Console.ReadLine();
            }
        }
    }