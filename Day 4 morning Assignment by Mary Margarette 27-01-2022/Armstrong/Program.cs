using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,rem, sum = 0,temp;
            Console.WriteLine("Enter a number :");
            n = Convert.ToInt32(Console.ReadLine());
            
            temp = n;
            while (n > 0)
            {
                rem = n%10;
                sum = sum + (rem*rem*rem);
                n = n / 10;
            }
            if (temp == sum)
            
                Console.WriteLine("{0} Armstrong Number",temp);
            
            else
                Console.WriteLine("{0} is Not Armstrong Number",temp);
            Console.ReadLine();



        }
    }
}
