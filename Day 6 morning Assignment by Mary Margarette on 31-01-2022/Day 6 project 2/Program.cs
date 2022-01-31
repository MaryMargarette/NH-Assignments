using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();

            int temp;
            int sum1 = 0, sum2 = 0;

            // print values using foreach loop
             for (int i = 0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]);
            }

            //print values using foreach loop

             foreach (var d in data)
            {
                Console.WriteLine(d);
            }

            // print values using lambda function
            data.ForEach(p => Console.WriteLine(p));

            Console.ReadLine();
        }
    }
}
