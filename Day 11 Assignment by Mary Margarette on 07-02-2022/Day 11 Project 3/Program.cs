using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_3
{
    //Author : Mary Margaret
    //Create Mathematics class and add 3 static methods and call the   methods in main method. 
    internal class Program
    {
        class Mathematics
        {
            public static int Add(int a , int b)
            {

                return a + b;
            }
            public static int Sub(int a, int b)
            {
                return a - b;

            }
            public static int Mul(int a, int b)
            {
                return a * b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(55,20));
            Console.WriteLine(Mathematics.Sub(85,80));
            Console.WriteLine(Mathematics.Mul(8,5));
            Console.ReadLine();


        }
    }
}
