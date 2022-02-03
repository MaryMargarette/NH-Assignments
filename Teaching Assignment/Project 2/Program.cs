using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    //Author: Mary Margaret
    //Purpose:Linear Search using Arrays
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Declaration and Initialization
            int[] elements = new int[] { 94, 10, 99, 66, 11 };
            Console.WriteLine("Enter number to search:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            //using for loop
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == num)
                {
                    Console.WriteLine($"The number {num},is in index{i},at position {i + 1}");
                    Console.ReadLine();                
                }
            }
            Console.WriteLine("The number not found");
            Console.ReadLine();
        }
    }
}