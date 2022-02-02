using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day_8_Project_5

{
    //Author: Mary Margaret 
    //Create Class Chocolates with 3 variables 
    //and using for loop, foreach loop, lambda expression and LINQ query print name and id whose price is >75

    class Chocolate

    {
        public int id;
        public string name;
        public int price;
    }

    internal class Program

    {
        static void Main(string[] args)

        {
            List<Chocolate> choc = new List<Chocolate>()
            {
                new Chocolate() { id = 125, name = "Bounty", price = 20},
                new Chocolate() { id = 126, name = "Dairy Milk", price = 80 },
                new Chocolate() { id = 127, name = "5 Star", price = 78},
                new Chocolate() { id = 128, name = "Munch", price = 10}

            };

            //for loop for which price >50

            for (int i = 0; i < choc.Count; i++)
            {
                if (choc[i].price > 50)
                {
                    Console.WriteLine(choc[i].name + "," + choc[i].id);
                }
            }


            //foreach loop for which price >50
            foreach (var c in choc)
            {
                if (c.price > 50)
                {
                    Console.WriteLine(c.name + "," + c.id);
                }
            }


            //lambda expression for which price >50
            choc.Where(c => c.price > 50).ToList().ForEach(c => Console.WriteLine(c.name + "," + c.id));


            //LINQ query for which price >50 

            var result = from c in choc
                         where c.price > 50
                         select c.name + "," + c.id;
            result.ToList().ForEach(c => Console.WriteLine(c));


            Console.ReadLine();
        }

    }

}