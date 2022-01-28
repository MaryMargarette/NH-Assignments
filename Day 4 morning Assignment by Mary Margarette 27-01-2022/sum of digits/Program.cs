using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,  rem, sum = 0;
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum=sum+rem;
                n = n / 10;
            }

            Console.WriteLine("Sum of digits of number {0} is {1}", temp, sum);
            Console.ReadLine();

        }
    }
}
