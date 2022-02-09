using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_7
{
    //Author: Mary Margaret
    //Queue Implementation
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(45);
            data.Enqueue(74);
            data.Enqueue(26);
            data.Enqueue(37);
            Console.WriteLine("No.Of elements queue contain : {0}", data.Count());
            data.Dequeue();
            Console.WriteLine("No.Of elements queue contain after dequeue : {0}", data.Count());
            Console.WriteLine("element on peek after pop is :{0}", data.Peek());
            Console.ReadLine();
        }
    }
}