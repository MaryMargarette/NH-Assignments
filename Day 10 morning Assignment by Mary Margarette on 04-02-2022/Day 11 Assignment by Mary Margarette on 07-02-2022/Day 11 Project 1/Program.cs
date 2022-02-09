using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_1
{
    //Author : Mary Margaret
    //Program for interfaces class IShape incluing the classes Cricle, Square, Triangle, Rectangle.
   
    interface IShape
    {
        int CalculateArea();
        int CalculatePerimeter();
        
    }
    class Square : IShape
    {
        int s;
        public void Readside()
        {
            Console.WriteLine("Enter side:");
            s = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return s * s;
        }

        public int CalculatePerimeter()
        {
            return 4 * s;
        }
    }
    class Rectangle : IShape
    {
        int l;
        int b;
        public void Readsides()
        {
            Console.WriteLine("Enter length:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth:");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return l*b;
        }

        public int CalculatePerimeter()
        {
            return 2*(l+b);
        }
    }
    class Triangle : IShape
    {
        int s;
        public void Readside()
        {
            Console.WriteLine("Enter side:");
            s = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 3 * s;
        }

        public int CalculatePerimeter()
        {
            return (3)^1/2*s*s/4;
        }
    }
    class Circle : IShape
    {
        int radius;
        public void Readradius()
        {
            Console.WriteLine("Enter radius:");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 22 * radius * radius / 7; 
        }

        public int CalculatePerimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            s.Readside();
            Console.WriteLine(s.CalculateArea());
            Console.WriteLine(s.CalculatePerimeter());

            Rectangle r = new Rectangle();
            r.Readsides();
            Console.WriteLine(r.CalculateArea());
            Console.WriteLine(r.CalculatePerimeter());

            Triangle t = new Triangle();
            t.Readside();
            Console.WriteLine(t.CalculateArea());
            Console.WriteLine(t.CalculatePerimeter());

            Circle c = new Circle();
            c.Readradius();
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(c.CalculatePerimeter());

            Console.ReadLine();
        }
    }
}
