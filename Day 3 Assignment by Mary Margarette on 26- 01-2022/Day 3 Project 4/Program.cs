using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[4];

            for(int i=0;i<data.Length;i++)
            {
                Console.WriteLine("Enter number");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The numbers entered are:");
            foreach(int i in data)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
