using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccessLibrary
{
    public static class EmpDAL
    {
        public static string filepath = "E:\\NH Assignments\\Final Project\\EmployeeData.txt";
        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            try
            {
                String textcontent = String.Concat(empid, ",", empname, ",", empsalary, ",", empage);
                File.AppendAllText(filepath, textcontent +Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public static List<String> GetEmployeeById(int empid)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;
            List<String> EmployeeFound = new List<String>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if(Convert.ToInt32(empDetails[0]) == empid)
                {
                    isFound = true;
                    EmployeeFound.Add(employee);
                    break;
                }
            }
            return EmployeeFound;
            
        }

 

        public static List<String> GetEmployeeByName(string empname)
        {
            var allEmployees = File.ReadAllLines(filepath);
            List<String> EmployeeFound = new List<String>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1] .Contains(empname))
                {
                    EmployeeFound.Add(employee);
                   
                }
            }
            return EmployeeFound;
            
              
        }

        public static string[] GetAllEmployee()
        {
            var result = File.ReadAllLines(filepath);
            return result;
        }



    }
}
