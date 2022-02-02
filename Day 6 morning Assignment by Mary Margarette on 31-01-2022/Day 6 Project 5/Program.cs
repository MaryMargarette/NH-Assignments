using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("Margaret");
            data.Add("Rajendra");
            data.Add("Tejaswi");
            data.Add("Reshma");
            data.Add("Sirisha");

            //using for loop
            for (int i = 0; i < data.Count; i++)
                Console.WriteLine(data[i]);


            //using foreach loop
            foreach (var d in data)
                Console.WriteLine(d);

            // using lamda function
            data.ForEach(d => Console.WriteLine(d));



            Console.ReadLine();
        }
    }
}
