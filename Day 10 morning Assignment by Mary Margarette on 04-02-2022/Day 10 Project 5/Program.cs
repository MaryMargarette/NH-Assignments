using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day_10_Project_4
{
    //Author:Mary Margaret
    //Purpose:Method Overriding
    class A 
    {
        string name;

        public void Reademp()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
        }

        public void Printemp()
        {
            Console.WriteLine("Employee name is {0}", name);
        }

        public void Company()
        {
            Console.WriteLine("NB Technologies");
        }
        public void ID()
        {
            string id = "NBTRN144";
            Console.WriteLine("Employee id is {0}", id);
        }
    }
    class B : A
    {

        public new void Company()
        {
            Console.WriteLine("NBH Technologies");
        }
  
        public new void ID()
        {
            string id = "NBTRN10";
            Console.WriteLine("Employee id is {0}", id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        
            A a = new A();
            a.Reademp();
            a.Printemp();
            a.Company();
            a.ID();
  
            B b = new B();
            Console.WriteLine("Employee Change to :");
            b.Company();
            b.ID();
            Console.ReadLine();
        }
    }
}