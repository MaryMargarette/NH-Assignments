using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_Project_1
{
    internal class Program
    {
        public static void Add(out int a, out int b)
        {
            a =15;
            b = 26;
        }
        static void Main(string[] args)
        {
            int i, j;
            Add(out i, out j);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();


        }
    }
}
