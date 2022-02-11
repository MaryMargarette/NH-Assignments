using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author : Mary Margaret
//Normal Properties
namespace Day_14_Project_5
{
    /// <summary>
    /// Normal Properties
    /// </summary>
    class Normal
    {
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Book
        {
            set
            {
                Book = value;
            }
        }
    }
    
    /// <summary>
    ///Auto Implemented Properties
    /// </summary>
    class Auto
    {
        public int Price { get; set; }
        public string Book 
        { 
            get
            {
                return "DIETETICS";

            }
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Creation for Normal Properties
            Console.WriteLine("Normal Properties :");
            Normal n = new Normal();
            n.Price = 550;
            Console.WriteLine(n.Price);
            Console.WriteLine("\n");
           
            //Object Creation for Auto Implemented Properties
            Console.WriteLine("Auto Implemented Properties :");
            Auto a = new Auto();
            a.Price = 560;
            Console.WriteLine(a.Price);
            Console.WriteLine(a.Book);
            Console.ReadLine();
        }
    }
}
