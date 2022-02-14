using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarryLibrary;

namespace Day_16_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------MatheMatics class-----\n");
            Mathematics mathematics = new Mathematics();
            mathematics.ReadData();
            Console.WriteLine("\nFactorial is "+mathematics.Factorial());
            Console.WriteLine("\n****Chemistry class******");
            Chemistry chemistry = new Chemistry();
            Console.WriteLine("\n"+chemistry.GetWater());
            Console.WriteLine("\n"+chemistry.GetMethane());
            Console.WriteLine("\n"+chemistry.GetBenzene());
            Console.WriteLine("\n#####PHYSICS$$$$$$\n");

            Physics physics = new Physics();
            Console.WriteLine("\nFinal Velocity is "+physics.FinalVelocity(5,4,3));
            Console.WriteLine("\nForce = "+physics.Force(5,4));

            Console.ReadLine(); 

        }
    }
}
