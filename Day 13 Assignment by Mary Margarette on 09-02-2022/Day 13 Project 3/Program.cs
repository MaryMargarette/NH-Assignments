using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_3
{
    //Author : Mary Margaret
    //Trace of the matrix with size (3,3)
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int sum = 0;
            int[,] data = new int[3, 3] { { 25, 75, 44 }, { 21, 87, 29 }, { 88, 26, 71} };
            
            //To print matrix
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(data[i,j] + "  ");
                }
                Console.WriteLine("\n");
            }
           
            //To print Trace of matrix
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    if (i == j)
                        sum = sum + data[i, j];
                }
            }
            Console.WriteLine("Trace of the given matrix is : {0}", sum);
            
           
            Console.ReadLine();
        }
    }
}
