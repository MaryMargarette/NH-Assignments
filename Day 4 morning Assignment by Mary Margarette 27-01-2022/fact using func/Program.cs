using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact_using_func
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            for(int i=1; i<n; i++)
            fact *= i;
            return fact;
        }
        public static void Print(int n) 
        { 
            Console.WriteLine("Factorial of {0} = {1}", n,Factorial(n));
        }
        static void Main(string[] args)
        {
            int n = 8 , n1 = 9, n2 = 7;
            Print(n);
            Print(n1);
            Print(n2);
            Console.ReadLine();
        }
    }
}
