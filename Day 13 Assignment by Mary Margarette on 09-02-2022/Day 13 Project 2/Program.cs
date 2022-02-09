using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_2
{
    internal class Program
    {
        //Author: Mary Margaret
        //Two-Dimesional Array with size (3,2)
        static void Main(string[] args)
        {
            //2-D Array Initialization
            int[,] data = new int[3, 2] { { 25, 75 }, { 21, 87 },{88,26} };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
