using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebC0.ServiceReference1;

namespace WebC0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Web1SoapClient wb = new Web1SoapClient();
            Console.WriteLine(wb.Factorial(5));
            Console.WriteLine(wb.Add(5,6));
            Console.WriteLine(wb.Mul(5,5));
            Console.WriteLine(wb.Div(8,2));

            Console.ReadLine();

        }
    }
}
