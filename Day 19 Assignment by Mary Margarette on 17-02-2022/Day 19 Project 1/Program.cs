using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Project_1
{
    //Author : Mary Margaret
    //read xml file
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("E:\\NH Assignments\\Day 18 Assignment by Mary Margarette on 16-02-2022\\Tag.xml");
            foreach(XmlNode xml2 in xml.DocumentElement.ChildNodes)
            {
                Console.WriteLine(xml2.InnerText);
            }
            Console.ReadLine();
        }
    }
}
