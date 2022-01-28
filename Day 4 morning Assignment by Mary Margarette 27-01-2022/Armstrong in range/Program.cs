using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_in_range
{
    internal class Program
    {
        public static bool Arm(int number)
        {
            int temp, rem, sum = 0;
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            for(int i=a; i<=b;i++)
            {
                if (Arm(i))
                    Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}