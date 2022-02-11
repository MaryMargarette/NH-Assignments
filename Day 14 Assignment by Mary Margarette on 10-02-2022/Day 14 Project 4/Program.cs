using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_4
{
    //Author: Mary Margaret
    //using Sealed class
    internal class Program
    {
        sealed class House
        {
            public static int Sqft = 800;
            public int GetPrice()
            {
                return 100000;
            }
        }

        static void Main(string[] args)
        {
            //object creation
            House h = new House();
            Console.WriteLine( "Price of the house is {0}", h.GetPrice() ); 
            Console.WriteLine("Area of the House in Sqft is {0}", House.Sqft);

            Console.ReadLine();
        }
    }
}
