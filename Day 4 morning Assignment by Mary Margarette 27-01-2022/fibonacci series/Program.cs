using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("enter input");
            input = Convert.ToInt32(Console.ReadLine());
            int next = 0;
            int prev = 0;
            for (int i = 0; i <= input; i++)
            {
                if (next == 0)
                {
                    next = 1;

                }
                else
                {
                    int temp = next;
                    next = next + prev;
                    prev = temp;
                }
                Console.WriteLine(next);
            }
            Console.ReadLine();
        }
    }
}
