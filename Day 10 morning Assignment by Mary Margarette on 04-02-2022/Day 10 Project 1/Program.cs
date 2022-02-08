using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day10Project1
{
    //Author :Mary Margaret
    //Purpose : Single inheritance
    class ADD 
    {
        /// <summary>
        /// This method finds sum of 3 numbers
        /// </summary>

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        
    }
    //child class
    class SUB : ADD 
    {
        /// <summary>
        /// This method find Difference
        /// </summary>

        public int Diff(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SUB s = new SUB();
            Console.WriteLine("Sum :");
            Console.WriteLine(s.Sum(1,45,55));
            Console.WriteLine("Difference :");
            Console.WriteLine(s.Diff(22, 10));
            Console.ReadLine();
        }
    }
}