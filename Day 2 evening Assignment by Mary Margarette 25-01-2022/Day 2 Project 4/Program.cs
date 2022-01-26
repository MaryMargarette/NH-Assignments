using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.WriteLine("Enter a number");
            num=Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(num+"x"+i+"=" + num*i);
            }
            Console.ReadLine();
        }
    }
}
