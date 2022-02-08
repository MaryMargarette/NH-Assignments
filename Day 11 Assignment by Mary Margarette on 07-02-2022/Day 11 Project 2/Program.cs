using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_2
{
    //Author : Mary Margaret
    //Write sample code to illustrate properties id name designation salary
    internal class Program
    {

        class Employee
        {
            private int id;
            private string name;
            private string designation;
            private int salary;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Designation
            {
                set { designation = value; }
            }
            public int Salary
            {
                get
                {
                    salary = (designation == "M") ? 85000 : 30000;
                    return salary;
                }

            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 88;
            Console.WriteLine(emp.Id);
            emp.Name = "Margaret";
            Console.WriteLine(emp.Name);
            emp.Designation = "M";
            Console.WriteLine(emp.Salary);

            Console.ReadLine();
        }
    }
}
