using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, avg;
            int[] data= new int[5];

            for(int i=0;i<data.Length;i++)
            {
                Console.WriteLine("Enter number");

                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in data)
            {
                sum = sum + i;
            }
            avg=sum/data.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadLine();
        }
    }
}
