using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_2
{
    //Author: Mary Margaret
    // To check if the number is prime or not using break; 
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 55;
            int i;
            for  (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
                if (i==n)
                    Console.WriteLine("{0} is a Prime Number",n);
                else
                    Console.WriteLine("{0} is not a Prime Number", n);
            Console.ReadLine();
            
        }
    }
}
