using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product "+Maths.Pro(5,4));
            Console.WriteLine("Addition "+Maths.Add(5,4));
            Console.WriteLine("Substraction "+Maths.Sub(8,2));
            Console.WriteLine("Division "+Maths.Div(6,2));
            Console.ReadLine();

        }
    }
}
