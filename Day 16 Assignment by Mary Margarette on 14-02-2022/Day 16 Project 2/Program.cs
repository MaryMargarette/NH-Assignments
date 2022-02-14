using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_2
{
    class Factorial
    {
        int n;
        public void ReadData()
        {
            Console.WriteLine("Enter number:");
            n=Convert.ToInt32(Console.ReadLine());
        }
        public int Fact()
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact=fact*i;
            }
            return fact;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            f.ReadData();
            Console.WriteLine("Factorail is "+f.Fact());
            Console.ReadLine();
        }
    }
}
