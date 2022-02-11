using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_3
{
    //Author : Mary Margaret
    //Num div by 97 from 1000 to 1097
    internal class Program
    {
        class Break
        {
            int n = 97;
            int i;
            public void Div()
            {
                for ( i = 1000; i <= 1097; i++)
                {
                    if (i % n == 0)
                        break;
                    
                }
                Console.WriteLine(i);

            }
        
    }
        static void Main(string[] args)
        {
            Break b = new Break();
            b.Div();

            Console.ReadLine();
        }
    }
}
