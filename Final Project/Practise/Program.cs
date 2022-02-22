using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practise
{
    internal class Program
    {
        public static string filepath = "E:\\NH Assignments\\Final Project\\EmployeeData.txt";
        static void Main(string[] args)
        {
            string empid = "NB26";
            string empname = "Margaret";
            int empsalary = 12000;
            int empage = 25;
            String textcontent = String.Concat(empid, ",", empname, ",", empsalary, ",", empage);
            File.AppendAllText(filepath, textcontent + Environment.NewLine);
            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
 