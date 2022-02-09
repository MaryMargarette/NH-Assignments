using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_10
{
    //Author : Mary Margaret
    //Adding of two Matrices
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] data1 = new int[2, 2];
            int[,] data2 = new int[2, 2];
            int[,] data3 = new int[2, 2];

            //Matrix 1
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter a number:");
                    data1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(data1[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            
            //Matrix 2
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.WriteLine("Enter a number:");
                        data2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(data2[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            //Adding two matrices

            Console.WriteLine("Addition of two matrices :");

            for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        data3[i, j] = data1[i,j]+data2[i,j];
                        Console.Write(data3[i,j] + "  ");
                    }
                Console.WriteLine("\n");
                }

 
            Console.ReadLine();

        }
    }
}
