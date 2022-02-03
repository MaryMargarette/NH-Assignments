using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    //Author: Mary Margaret
    //Purpose:Bubble sort implementation

    class Sort //Sort class declaration
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                int[] b = new int[] { 88, 23, 10, 89, 2, 45 };
                int temp;

                //printing values before sorting

                Console.WriteLine("Before Sorting:");

                //Lambda Expression

                b.ToList().ForEach(x => Console.WriteLine(x));

                for (int i = 0; i <= b.Length - 2; i++)
                {
                    for (int j = 0; j <= b.Length - 2; j++)
                    {
                        if (b[j] > b[j + 1])
                        {
                            temp = b[j + 1];
                            b[j + 1] = b[j];
                            b[j] = temp;
                        }
                    }
                }

                Console.WriteLine("After Sorrting:");

                //foreach loop to print values from array

                foreach (var d in b)
                    Console.WriteLine(d);

                Console.ReadLine();
            }
        }
    }
}
