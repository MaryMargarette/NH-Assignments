using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_9
{
    //Author:Mary Margaret
    //Addition of 2 D Array
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data1 = new int[2, 2] ;

            int[,] data2 = new int[2, 2] ;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter a number:");
                    data1[i, j] = Convert.ToInt32(Console.ReadLine());
                    data2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data1[i,j] + data2[i,j] + " ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
