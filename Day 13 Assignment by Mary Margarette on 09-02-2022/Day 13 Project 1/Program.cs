using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_1
{
    //Author : Mary Margaret
    //Two Dimensional Array
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-D Array Initialization
            int[,] data = new int[2, 2];
            data[0, 0] = 12;
            data[0,1] = 52;
            data[1, 0] = 48;
            data[1, 1] = 15;

            for(int i = 0; i < 2; i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(data[i,j]+"  "); 
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
