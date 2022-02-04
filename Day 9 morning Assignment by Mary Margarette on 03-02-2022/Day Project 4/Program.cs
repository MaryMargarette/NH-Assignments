using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Project_4
{
    //Author : Mary Margaret
    //Purpose: Create Employee class with 2 constructors

    class Employee 
    {
        
        public int id;
        public string name;
        public int salary;
        public static string company = "NBH Technologies";
        // default constructor
        public Employee()
        {
            this.id = 0;
            this.name = null;
            this.salary = 0;
        }

        //Constructor
        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }


        public void ReadInput()
        {
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method givess Employee data
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"Employee id : {id}, Employee Name  {name}, Salary = {salary},Company={company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object1 creation
            Employee emp = new Employee();
            emp.ReadInput();
            emp.PrintData();

            Console.ReadLine();
        }
    }
}