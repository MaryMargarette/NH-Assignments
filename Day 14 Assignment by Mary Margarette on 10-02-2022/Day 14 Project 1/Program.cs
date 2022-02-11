using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_1
{
    //Author: Mary Margaret
    //printing 1 to 30 num using continue; and skipping div 3 numbers.
    internal class Program
    {
     
        static void Main(string[] args)
        {
            int n = 1;
            for(int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
