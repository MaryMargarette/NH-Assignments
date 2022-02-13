using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAY_15_Project_4
{
    //Author:Mary Margaret
    //using Stream Reader
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Files\\Hi.txt");
            string data = sr.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }
            Console.WriteLine("\n\n\nReading done");
            Console.ReadLine();
        }
    }
}
