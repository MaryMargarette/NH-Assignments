using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_check
{
    internal class Program
    {
        public static void Prime(int input)
        {
            int i;
            for(i=2;i<input;i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
            {
                Console.WriteLine("{0} is prime",input);
            }
            else
            {
                Console.WriteLine("{0} is not a prime", input);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter input");
            Prime(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
