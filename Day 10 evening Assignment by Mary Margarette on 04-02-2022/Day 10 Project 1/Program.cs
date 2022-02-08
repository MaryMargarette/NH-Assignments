using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_1
{
    //Author: Mary Margaret
    //Purpose : Abstraction

    abstract class Salary
    {
        public int Getpf(int basic)
        {
            return 12 * basic / 100;
        }
        public int GetHRA(int basic)
        {
            return 40 * basic / 100;
        }
        public abstract int GetCA();
        public abstract int GetSA();
    }
    class Intel : Salary
    {
        public override int GetCA()
        {
            return 1000;
        }
        public override int GetSA()
        {
            return 2000;
        }
    }
    class Dell : Salary
    {
        public override int GetCA()
        {
            return 10000;
        }
        public override int GetSA()
        {
            return 20000;
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Completed Processing");
        Console.ReadLine();
        }
    }

