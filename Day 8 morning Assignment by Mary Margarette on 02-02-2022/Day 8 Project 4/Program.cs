using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day_8_Project_4

{
    //Author: Mary Margaret 
    //Create Class Department with 3 variables 
    //and using for loop, foreach loop, lambda expression and LINQ query print name and id whose empcount is >50

    class Department

    {
        public int id;
        public string name;
        public int empcount;
    }

    internal class Program

    {
        static void Main(string[] args)

        {
            List<Department> dept = new List<Department>()
            {
                new Department() { id = 888, name = "Police Dept", empcount = 80},
                new Department() { id = 889, name = "Medical Dept", empcount = 30},
                new Department() { id = 890, name = "Revenue Dept", empcount = 59},
                new Department() { id = 891, name = "Municipal Dept", empcount = 36}

            };

            //for loop for which empcount >50

            for (int i = 0; i < dept.Count; i++)
            {
                if (dept[i].empcount > 50)
                {
                    Console.WriteLine(dept[i].name + "," + dept[i].id);
                }
            }


            //foreach loop for which empcount >50
            foreach (var d in dept)
            {
                if (d.empcount > 50)
                {
                    Console.WriteLine(d.name + "," + d.id);
                }
            }


            //lambda expression for which empcount >50
            dept.Where(d => d.empcount > 50).ToList().ForEach(d => Console.WriteLine(d.name + "," + d.id));


            //LINQ query for which price >50 

            var result = from d in dept
                         where d.empcount > 50
                         select d.name + "," + d.id;
            result.ToList().ForEach(d => Console.WriteLine(d));


            Console.ReadLine();
        }

    }

}