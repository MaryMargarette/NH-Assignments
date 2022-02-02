using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day_6_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();
            int sum = 0;
            data.Add(50);
            data.Add(61);
            data.Add(72);
            data.Add(83);
            data.Add(94);

            foreach(var d in data)
            {
                sum = sum + (int) d;
                
            }
            Console.WriteLine("sum of given numbers"  + sum);
            Console.ReadLine();
        }
    }
}
