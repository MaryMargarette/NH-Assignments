using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day_10_Project_3
{
    //Author:Mary Margaret
    //Purpose: Method Overloading
    class MethodOverloading
    {
        /// <summary>
        /// This method is to find sum
        /// </summary>
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
    class Method_Overloading
    {
        /// <summary>
        /// This method is to find sum
        /// </summary>

        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation for class1
            MethodOverloading m = new MethodOverloading();
            Console.WriteLine("Subtraction of given numbers is {0} ", m.Sub(8,2,1));
            Console.WriteLine("Addition of numbers is {0} ", m.Add(10,12,14,24));
            
            Method_Overloading m2 = new Method_Overloading();
            Console.WriteLine("Subtraction of given numbers is {0} ", m2.Sub(8, 2, 1));
            Console.WriteLine("Addition of numbers is {0} ", m2.Add(10, 12, 14, 24));
            Console.WriteLine("Float Sum is {0}", m2.Add(5.6f, 3.5f));
            Console.ReadLine();
        }
    }
}