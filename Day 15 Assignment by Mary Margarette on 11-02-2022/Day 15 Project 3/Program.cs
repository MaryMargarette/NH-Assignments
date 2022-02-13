using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_15_Project_3
{
    //Author:Mary Margaret
    //file appended with stream writer
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Files\\Hi.txt", true);
            sw.WriteLine("\n");
            sw.WriteLine("All tASKS ARE COMPLETED");
            sw.WriteLine("All tasks are Executed");
            sw.Close();
            Console.WriteLine("File Appended");
            Console.ReadLine();
        }
    }
}
