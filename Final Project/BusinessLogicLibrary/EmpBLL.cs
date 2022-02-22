using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataAccessLibrary;

namespace BusinessLogicLibrary
{
    public static class EmpBLL
    {
        private static string filepath;

        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            var result = EmpDAL.AddEmployee(empid, empname, empsalary, empage);
                return result;
        }

        public static List<String> GetEmployeeById(int empid)
        {

            var result = EmpDAL.GetEmployeeById(empid);
            return result;
        }

        public static List<String> GetEmployeeByName(string empname)
        {
            var result = EmpDAL.GetEmployeeByName(empname);
            return result;

        }

        public static string[] GetAllEmployee()
        {
            var result = EmpDAL.GetAllEmployee();
            return result;
        }
    }
}
       
