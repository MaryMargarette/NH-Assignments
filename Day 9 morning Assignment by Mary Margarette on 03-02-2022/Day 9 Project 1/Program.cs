using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Project_1
{
    //Author : Mary Margaret
    //Purpose: Create class and object to print factotial, factors and prime or not.
    class MathsOperation
    {
        private int input;
        public void ReadInput()
        {
            Console.WriteLine("Enter number:");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method finds Factorial of a given number
        /// </summary>
        public void Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
                fact = fact * i;
            Console.WriteLine(fact);
        }
        /// <summary>
        /// This method find the factors of a given number.
        /// </summary>
        public void PrintFactors()
        {
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.WriteLine("Factors of given number are {0} ", i);
            }
        }
        /// <summary>
        /// This is method is to check whether given is Prime or not
        /// </summary>
        /// <returns>isPrime<returns>
        public bool isPrime()
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MathsOperation obj = new MathsOperation();
            obj.ReadInput();
            obj.Factorial();
            obj.PrintFactors();
            if(obj.isPrime())
                Console.WriteLine("Input is Prime");
            else
                Console.WriteLine("Input is not a Prime");


            Console.ReadLine();
        }
    }
}