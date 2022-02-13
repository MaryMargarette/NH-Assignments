using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day_15_Project_2
{
    //Author: Mary Margaret
    //copying code from on to another folder
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("C:\\source\\copy.txt", "C:\\Files\\Hi.txt");
            Console.WriteLine("File Copied");

        }
    }
}
