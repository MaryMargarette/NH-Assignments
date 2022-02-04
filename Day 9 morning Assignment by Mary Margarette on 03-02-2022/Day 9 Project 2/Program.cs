using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project2
{
    //Author: Mary Margaret
    //Purpose: Create class and objects for verifying add, sub, mul, div of given numbers
    class MathTask
    {
        //variable declaration
        public int a, b;

        public void ReadInput()
        {
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method is to find the sum
        /// </summary>
        /// <returns>sum</returns>
        public int Sum()
        {
            return a + b;
        }
        /// <summary>
        /// This method is to find Difference
        /// </summary>
        /// <returns>Difference</returns>
        public int Difference()
        {
            return a - b;
        }
        /// <summary>
        /// This method is used to Multiply
        /// </summary>
        /// <returns>Prouduct</returns>
        public int Multiply()
        {
            return a * b;
        }
        /// <summary>
        /// This method is used to Divide
        /// </summary>
        /// <returns>Quotient</returns>
        public int Division()
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation
            MathTask obj = new MathTask();
            obj.ReadInput();
            Console.WriteLine(obj.Sum());
            Console.WriteLine(obj.Difference());
            Console.WriteLine(obj.Multiply());
            Console.WriteLine(obj.Division());

            Console.ReadLine();

        }
    }
}