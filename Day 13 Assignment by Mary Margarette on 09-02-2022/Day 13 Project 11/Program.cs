using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_11
{
    //Author:Mary Margaret
    //Multiplication of two matrices
    internal class Program
    {
        static void Main(string[] args)
        {
            //r1,c1 are rows and columns of matrix data1
            //r2,c2 are rows and columns of matrix data2
            int i, j;
            int r1 = 2;
            int r2 = 2;
            int c1 = 2;
            int c2 = 2;
            int[,] data1 = new int[r1, c1];//array of data1
            int[,] data2 = new int[r2, c2];//array of data2


            //Matrix 1 reading  input
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter a number:");
                    data1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //printing matrix data1

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(data1[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            //Matrix 2 reading input
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter a number:");
                    data2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Printing matrix data2
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(data2[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            //Multiplication of two matrices
            if (c1 == r2) //condition for matrix multiplication
            {
                int[,] c = new int[r1, c2];
                Console.WriteLine("Matrix Multiplication:");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < r2; k++)
                        {
                            c[i, j] += data1[i, k] * data2[k, j];
                        }
                        Console.Write(c[i, j] + " ");
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadLine();
            }
        }
    }
}