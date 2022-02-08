using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12_Project_1
{
    internal class Program
    {
        //Author : Mary Margaret
        //Exception Handling
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter first number :");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Division of two numbers : {0} ", c);
                Console.ReadLine();
            }
            

           catch (OverflowException)//exception for large numbers
            {
                Console.WriteLine("please give numbers between 0 and 700000");
                Console.ReadLine();
            }
            catch (DivideByZeroException)//exception when divide with zero
            {
                Console.WriteLine("Number Can't divided by zero");
                Console.ReadLine();
            }
            catch(FormatException)//exception when format is not correct
            {
                Console.WriteLine("sorry only numbers are accepted, please check again");
                Console.ReadLine();
            }
            catch(Exception)//super exception
            {
                Console.WriteLine("something went wrong please contact admin@nbh.com");
                Console.ReadLine();
            }

            
        }
    }
}
