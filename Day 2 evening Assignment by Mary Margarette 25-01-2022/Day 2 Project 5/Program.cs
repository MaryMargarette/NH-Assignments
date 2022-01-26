using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i=1;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            while (i<=10)
            {
                Console.WriteLine(num + "x" + i + "=" + num * i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
