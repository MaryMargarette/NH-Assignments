using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input;

            Console.WriteLine("Enter Character");
            input = Convert.ToChar(Console.ReadLine());

            switch(input)
            {
                case 'a':

                case 'e':

                case 'i':

                case 'o':

                case 'u':
                    Console.WriteLine("The input given is vowel"+ input);
                    break; 
                    default:
                    Console.WriteLine("The input is Consonant"+ input);
                    break;
            }
            Console.ReadLine();
        }
    }
}
