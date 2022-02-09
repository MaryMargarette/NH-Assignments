using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_4
{
    //Author: Mary Margaret
    //2-D Array with user inputs
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
             
            int[,] data = new int[2, 2] ;
            for ( i = 0; i < 2; i++)
            {
                for ( j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter a number:");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                   
                }    
                
            }
            for( i = 0; i < 2;i++)
            {
                for( j = 0;j < 2;j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
