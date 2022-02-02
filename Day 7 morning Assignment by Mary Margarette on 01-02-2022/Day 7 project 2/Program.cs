using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day7Project2
{
    //Author:Mary Margaret
    /*Purpose:creating Classes:
    1. customer
    2. product
    3. seller
    4. department
    */
    class Customer //Class Declaration
    {
        //variable Declaration
        private int cid;
        private string cname;
        private int cnum;
        //Methods Declaration
        public void ReadCustomer() 
        {
            Console.WriteLine("Enter Customer id:");
            cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customername:");
            cname = Console.ReadLine();
            Console.WriteLine("Enter Customer mobile number:");
            cnum = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintCustomer() 
        {
            Console.WriteLine($"CustomerId={cid}, Customername={cname}, Mobile number={cnum}");
        }
    }
    class Products //Class Declaration
    {
        //variable Declaration
        private int pid;
        private string pname;
        private string pbrand;
        //Methods Declaration
        public void ReadProduct() 
        {
            Console.WriteLine("Enter Product id:");
            pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product name:");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Brand of product:");
            pbrand = Console.ReadLine();
        }
        public void PrintProduct() 
        {
            Console.WriteLine($"ProductId={pid}, Productname={pname}, ProductBrand={pbrand}");
        }
    }
    class Seller //Class Declaration
    {
        //variable Declaration
        private int sid;
        private string sname;
        private int snum;
        //Methods Declaration
        public void ReadSeller() 
        {
            Console.WriteLine("Enter Seller id:");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Seller name:");
            sname = Console.ReadLine();
            Console.WriteLine("Enter Seller mobile number:");
            snum = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintSeller() 
        {
            Console.WriteLine($"SellerId={sid}, Sellername={sname}, SellerMobile number={snum}");
        }
    }
    class Department //Class Declaration
    {
        //variable Declaration
        private int did;
        private string dname;
        private string ddescription;
        //Methods Declaration
        public void ReadDepartment() 
        {
            Console.WriteLine("Enter Department id:");
            did = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department name:");
            dname = Console.ReadLine();
            Console.WriteLine("Enter Department Description: ");
            ddescription = Console.ReadLine();
        }
        public void PrintDepartment() 
        {
            Console.WriteLine($" DepartmentId={did}, Departmentname={dname},  DepartmentDescription={ddescription}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer();
            a.ReadCustomer();
            a.PrintCustomer();
            Products b = new Products();
            b.ReadProduct();
            b.PrintProduct();
            Seller c = new Seller();
            c.ReadSeller();
            c.PrintSeller();
            Department d = new Department();
            d.ReadDepartment();
            d.PrintDepartment();
            Console.ReadLine();
        }
    }
}
