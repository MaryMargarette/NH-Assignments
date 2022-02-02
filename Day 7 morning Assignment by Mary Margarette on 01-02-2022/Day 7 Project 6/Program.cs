using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_6
{
    //Author: Mary Margaret
    //create object and initialise with 5 values and write code to print Custormers whose count>=4 using for,foreach,lambda expression  

    class Customer //class declaration  

    {
        //variables declaration  

        public int id;

        public string name;

        public int count;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] c = new Customer[]
            {
                //initialising object with values
                new Customer() { id = 10, name = "Ajith", count = 5},
                new Customer() { id = 20, name = "Balu", count = 4},
                new Customer() { id = 30, name = "Charitha",count = 3},
                new Customer() { id = 40, name = "Naira", count = 5},
                new Customer() { id = 50, name = "Samuel", count = 2}
            };
            //for loop
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].count >= 4)
                    Console.WriteLine($"id={c[i].id},name={c[i].name},CustomerCount={c[i].count}");
            }
            //foreach loop
            foreach (var d in c)
            {
                if (d.count >= 4)
                    Console.WriteLine($"id={d.id},name={d.name},CustomerCount={d.count}");
            }
            //lambda expression
            c.ToList().Where(e => e.count >= 4).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name}, CustomerCount={e.count}"));
            Console.ReadLine();
        }
    }
}
