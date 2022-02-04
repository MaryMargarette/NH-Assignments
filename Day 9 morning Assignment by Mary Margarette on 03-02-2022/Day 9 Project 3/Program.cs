using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Project_3
{
    //Author : Mary Margaret
    //Purpose: Create Employee class and print data 

    class Employee 
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NBH Technologies";

        public void ReadData()
        {
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method gives Employee data
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"Employee id : {id}, Employee Name  {name}, Employee Salary = {salary}, Company={company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object1 creation
            Employee emp = new Employee();
            emp.ReadData();
            emp.PrintData();
            //object2 creation
            Employee emp1 = new Employee();
            emp1.ReadData();
            emp1.PrintData();

            Console.ReadLine();
        }
    }
}
