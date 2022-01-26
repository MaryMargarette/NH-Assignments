using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("enter a number");
            num=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                if(num%i==0)
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
