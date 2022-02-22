using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
using System.IO;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Employee Managment Application");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Get Employee By ID");
                Console.WriteLine("3.Get Employee By Name");
                Console.WriteLine("4.Get All Employess");
                Console.WriteLine("Enter Choice :");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        GetEmployeeById();
                        break;
                    case 3:
                        GetEmployeeByName();
                        break;
                    case 4:
                        GetAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Do You want to continue Y/N : ");
                choice = Console.ReadLine();
            }while (choice.Equals("Y"));

        }
        public static void AddEmployee()
        {
            int empid, empage, empsalary;
            string empname;
            Console.WriteLine("Enter ID :");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary :");
            empsalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age :");
            empage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            empname =Console.ReadLine();

            var result = EmpBLL.AddEmployee(empid, empname, empsalary,empage);

            if(result)
                Console.WriteLine("Employee Details Saved Successfully");
            else
                Console.WriteLine("Some Error Occured");
        }

        public static void GetEmployeeById()
        {
            int empid;
            Console.WriteLine("Enter ID :");
            empid = Convert.ToInt32(Console.ReadLine());

            var result = EmpBLL.GetEmployeeById(empid);
            if (result.Count == 0)
                Console.WriteLine("No Data");
            else
                result.ForEach(d => Console.WriteLine(d));
        }
        public static void GetEmployeeByName()
        {
            string empname;
            Console.WriteLine("Enter Name :");
            empname = Console.ReadLine();

            var result = EmpBLL.GetEmployeeByName(empname);
            if (result.Count == 0)
                Console.WriteLine("No Data");
            else
                result.ForEach(d => Console.WriteLine(d));
        }
        public static void GetAllEmployees()
        {
            var result = EmpBLL.GetAllEmployee();
            result.ToList().ForEach(d=> Console.WriteLine(d));
        }
    }
}
