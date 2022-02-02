using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Project_1
{
    internal class Program
    {
        //Author : Mary Margaret
        //create list and using for loop, foreach loop, lambda expression and LINQ query find even numbers
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 10, 22, 33, 44, 55, 66, 77, 88};

            //for loop to print even numbers from list
            for(int i=0;i<data.Count;i++)
            {
                if(data[i]%2==0)
                    Console.WriteLine(data[i]);
            }

            //foreach loop to print even numbers from list
            foreach(var d in data)
            {
                if(d % 2 == 0)
                Console.WriteLine(d);
            }
               

            //lambda expression to print even numbers from list
            data.Where(d=>d%2==0).ToList().ForEach(d => Console.WriteLine(d));

            //LINQ query to print even numbers from list
            var result=from d in data
                       where d%2==0
                       select d;
            result.ToList().ForEach(d => Console.WriteLine(d));

            Console.ReadLine();
        }
    }
}
