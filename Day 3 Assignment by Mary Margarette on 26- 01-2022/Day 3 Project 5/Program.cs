using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, a;
            int[] data = new int[] { 2, 8, 26, 10, 97 };
            foreach (int d in data)
            {
                sum += d;
            }
            a = sum / 5;
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("Average is " + a);
            Console.ReadLine();
        }
    }
}
