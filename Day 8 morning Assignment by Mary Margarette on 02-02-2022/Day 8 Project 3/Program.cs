using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day_8_Project_3

{

    //Author: Mary Margaret 

    //Create Class Product with 4 variables 
    //and using for loop, foreach loop, lambda expression and LINQ query print name and brand whose price is >50

    class Product

    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }

    internal class Program

    {
        static void Main(string[] args)

        {
            List<Product> products = new List<Product>()
            {
                new Product() { id = 362, name = "Earphones", price = 800, brand="Realme" },
                new Product() { id = 363, name = "Speaker", price = 3200, brand="JBL" },
                new Product() { id = 364, name = "Mobile", price = 9000, brand="samsung" },
                new Product() { id = 365, name = "Notebook", price = 45, brand="classmate" }

            };

            //for loop for which price >50

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].price > 50)
                {
                    Console.WriteLine(products[i].name + "," + products[i].brand);
                }
            }


            //foreach loop for which price >50
            foreach (var p in products)
            {
                if (p.price > 50)
                {
                    Console.WriteLine(p.name + "," + p.brand);
                }
            }


            //lambda expression for which price >50
            products.Where(p => p.price > 50).ToList().ForEach(p => Console.WriteLine(p.name + "," + p.brand));


            //LINQ query for which price >50 

            var result = from p in products
                         where p.price > 50
                         select p.name + "," + p.brand;
            result.ToList().ForEach(d => Console.WriteLine(d));


            Console.ReadLine();
        }

    }

}