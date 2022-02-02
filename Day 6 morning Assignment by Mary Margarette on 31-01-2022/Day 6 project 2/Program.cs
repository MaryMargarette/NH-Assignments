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
            int sum = 0;
            data.Add(1);
            data.Add(2);
            data.Add(3);
            data.Add(4);
            data.Add(5);

            // print values using foreach loop
            foreach (var d in data)

            {
                sum = sum + (int)d;

            }

            Console.WriteLine("sum of given numbers"   + sum);

            Console.ReadLine();

        }
    }
}
