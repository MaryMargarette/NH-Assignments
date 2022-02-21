using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Project_4
{
    //Author:Mary Margaret
    //Read data from user for xml file
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter ID:");
            i = Convert.ToInt32(Console.ReadLine());
            XmlDocument xml = new XmlDocument();
            xml.Load("E:\\NH Assignments\\Day 18 Assignment by Mary Margarette on 16-02-2022\\Tag.xml");
            foreach (XmlNode xml2 in xml.DocumentElement.ChildNodes)
            {
                foreach (XmlNode xml3 in xml2.ChildNodes)
                {
                    bool id = xml3.Name == "ID";
                    bool isIndex = (id == true ? Convert.ToInt32(xml3.InnerText) : 0) == i;
                    if (id && isIndex)
                    {
                        Console.WriteLine($"{xml3.NextSibling.InnerText}");
                    }
                }

            }
            Console.ReadLine();

        }
    }
}
