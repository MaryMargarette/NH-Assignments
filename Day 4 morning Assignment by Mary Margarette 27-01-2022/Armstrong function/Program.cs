using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_function
{
    internal class Program
    {
        public static bool Arm(int number)
        {
            int temp,rem, sum = 0;
            temp = number;
            while(number>0)
            {
                rem= number%10;
                sum=sum+(rem*rem*rem);
                number=number/10;
            }
            if(temp==sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number=Convert.ToInt32(Console.ReadLine());
            if (Arm(number) == true)
                Console.WriteLine("{0} is Armstrong Number", number);
            else
                Console.WriteLine("{0} is not Armstrong Number", number);
            Console.ReadLine();
        }
    }
}
