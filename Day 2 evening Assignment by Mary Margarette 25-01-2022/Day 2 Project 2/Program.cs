using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, num;
            Console.WriteLine("enter a number");
            num= Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
 
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
