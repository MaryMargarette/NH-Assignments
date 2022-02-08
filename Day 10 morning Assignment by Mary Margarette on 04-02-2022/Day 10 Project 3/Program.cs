using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_3
{
    //Author: Mary Margaret
    //code for method overriding using virtual, override keyword.
    public class Mobile
    {
        string name = "Samsung";
        //using virtual keyword
        public virtual void showdata()
        {
            Console.WriteLine("Name of mobile is " + name);
        }
    }

    class Model : Mobile
    {

        string s = "M30s";
        //uding override keyword
        public override void showdata()
        {
            base.showdata();

            Console.WriteLine("Model is " + s);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Model m = new Model();
            m.showdata();
            Console.ReadLine();
        }
    }
}
