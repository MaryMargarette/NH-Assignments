using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day_10_Project_2
{
    //Author :Mary Margaret
    // Multi-Level Inheritance
    class Employee 
    {
        /// <summary>
        /// This method gives name of employee
        /// </summary>
        public void Printname()
        {
            Console.WriteLine("Employee name is Margaret");
        }
        /// <summary>
        /// This method prints id of employee
        /// </summary>
        public void Printid(int a)
        {
            Console.WriteLine("ID of employee is {0}", a );
        }
    }
    class Salary : Employee 
    {
        /// <summary>
        /// This method shows salary of employee
        /// </summary>
        public void Amount(int a)
        {
            Console.WriteLine("salary of employee is {0} ", a);
        }
    }
    class Phone : Salary 
    {
        /// <summary>
        /// This method gives phone number of employee
        /// </summary>
        public void Phn(int a)
        {
            Console.WriteLine("Phone number of employee is {0} :" ,a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Phone p = new Phone();
            p.Printname();
            p.Printid(101);
            p.Amount(20);
            p.Phn(889966);
            Console.ReadLine();
        }
    }
}