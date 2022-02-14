using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_5
{
    class Palindrome
    {
        int n;
        int sum = 0;
        int rem;
        int temp;
        public void ReadData()
        {
            Console.WriteLine("Enter number:");
            n=Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            temp = n;
            while(n>0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome p=new Palindrome();
            p.ReadData();
            p.Print();
            Console.ReadLine();
        }
    }
}
