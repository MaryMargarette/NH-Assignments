using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_8
{
    //Author :Mary Margaret
    //Factorial with Recursion 
    internal class Program
    {
        class Factorial
        {
            public static int Fact(int n)
            {
                if (n == 0)
                {
                    return 1;
                }

                else
                {
                    return n * Fact(n - 1);
                }
    
                    
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of number is :{0}",Factorial.Fact(7));
            Console.ReadLine();
        }
        
    }
}
