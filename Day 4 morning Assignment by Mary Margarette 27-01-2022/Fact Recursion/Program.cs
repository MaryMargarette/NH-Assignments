using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact_Recursion
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n*Factorial(n-1);
        }
        public static void print(int n)
        {
            Console.WriteLine("Factorial of {0} = {1}",n,Factorial(n));
        }
        static void Main(string[] args)
        {
            int n = 8, n1=6, n2=4;
            print(n);
            print(n1);
            print(n2);  
            Console.ReadLine();
        }
    }
}
