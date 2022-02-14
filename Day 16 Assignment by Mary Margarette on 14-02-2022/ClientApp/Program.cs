using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaryLibrary1;
using PublicLibrary;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial is "+Maths.Fact(5));
            Console.WriteLine("Final Velocity "+Physics.FinalVelocity(5, 4, 5));
            Console.WriteLine("Methane "+Chemistry.GetMethane());
            Console.WriteLine("Benzene "+Chemistry.GetBenzene());
            Console.ReadLine();
        }
    }
}
