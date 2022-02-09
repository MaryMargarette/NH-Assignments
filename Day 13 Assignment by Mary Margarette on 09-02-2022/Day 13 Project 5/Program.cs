using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_5
{
    //Author:Mary Margaret
    //Jagged Array
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[4][];
            names[0]= new char[] { 'M','A','R','Y'};
            names[1] = new char[] { 'M', 'A', 'R', 'G','A','R','E','T' };
            names[2] = new char[] { 'T', 'E', 'J', 'A' };
            names[3] = new char[] { 'K','I','R', 'A', 'N' };

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
