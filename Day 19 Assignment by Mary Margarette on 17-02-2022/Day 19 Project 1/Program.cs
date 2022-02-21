using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("E:\\NH Assignments\\Day 18 Assignment by Mary Margarette on 16-02-2022\\Tag.xml");
            xml node = xml.DocumentElement.SelectSingleNode("//employees//employee");
            foreach(XmlNode node2 in .Documentelement.ChildNodes)

        }
    }
}
