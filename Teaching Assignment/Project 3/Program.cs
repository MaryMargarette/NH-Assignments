using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    //Author: Mary Margaret
    //Purpose: Binary search using Arrays
    internal class Program
    {
        public static int Binarysearch(int[] a, int s)
        {
            int left = 0;
            int right = a.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (s < a[mid])
                {
                    right = mid - 1;
                }

                else if (s > a[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            // Array declaration and Initialization
            int[] a = new int[] { 43, 87, 6, 91, 58 };
            Console.WriteLine("Enter search element:");
            int s = Convert.ToInt32(Console.ReadLine());
            int result = Binarysearch(a, s);

            if (result <= 0)
            {
                Console.WriteLine($"Search item {s} not found");
            }
            else
            {
                Console.WriteLine($"Search item {s} Found at index {result}");
            }
            Console.ReadLine();

        }
    }
}