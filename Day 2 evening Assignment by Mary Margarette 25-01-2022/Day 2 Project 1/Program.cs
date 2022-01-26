using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,sum = 0,input;

            Console.WriteLine("enter numbers");
           input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <=input; i++)
            {
                sum = sum + i; 
            }


            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
