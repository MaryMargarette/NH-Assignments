using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12_Project_2
{
    internal class Program
    {
        //Author : Mary Margaret
        //Example for finally block

        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter first number :");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());
                c = a * b;
                Console.WriteLine("Division of two numbers : {0} ", c);
            }
            catch (OverflowException)//exception for large numbers 

            {
                Console.WriteLine("please give numbers between 0 and 700000");
                Console.ReadLine();
            }

            finally
            {
                Console.WriteLine("\n\n\n\n\n\nDesigned by Mary Margaret");
                Console.ReadLine();
            }
        }
        
    }
}
