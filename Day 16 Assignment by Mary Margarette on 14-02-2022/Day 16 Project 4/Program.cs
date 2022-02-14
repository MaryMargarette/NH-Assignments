using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_4
{
    class Multiplication
    {
        int n;
        public void ReadData()
        {
            Console.WriteLine("Enter number:");
            n=Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n+"*"+i+"="+n*i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiplication multiplication = new Multiplication();
            multiplication.ReadData();
            multiplication.Print();
            Console.ReadLine();
        }
    }
}
