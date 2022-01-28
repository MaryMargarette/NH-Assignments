using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_with_3var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp,a, b;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping {0} {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swapping {0} {1}", a, b);
            Console.ReadLine();

        }
    }
}
