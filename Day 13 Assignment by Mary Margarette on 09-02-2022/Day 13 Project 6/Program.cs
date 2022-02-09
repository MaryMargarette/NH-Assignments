using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_6
{
    //Author: Mary Margaret
    //Stack Implementation
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(18);
            data.Push(85);
            data.Push(56);
            data.Push(12);
            Console.WriteLine("No.Of elements stack contain : {0}", data.Count()); 
            data.Pop();
            Console.WriteLine("No.Of elements stack contain after pop : {0}", data.Count());
            Console.WriteLine("element on peek after pop is :{0}",data.Peek());
            Console.ReadLine();
        }
    }
}
