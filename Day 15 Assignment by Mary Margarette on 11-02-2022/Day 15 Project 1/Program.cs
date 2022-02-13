using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_15_Project_1
{
    //Author:Mary Maragret
    //10 methods in files
    internal class Program
    {
        static void Main(string[] args)
        {
            // create file
            File.Create("C:\\Files\\Hi.txt");
            Console.WriteLine("File Created ");


            //create text
            File.WriteAllText("C:\\Files\\Hi.txt", "Hello Everyone");
            Console.WriteLine("Text Created");

            //Stream Writer
            StreamWriter sw = new StreamWriter("C:\\Files\\Hi.txt");
            sw.WriteLine("Good Morning");
            sw.Close();
            Console.WriteLine("Stream Written");

            //To Apend 
            StreamWriter sw = new StreamWriter("C:\Files",true);
            sw.WriteLine("How Are You?");
            sw.Close();
            Console.WriteLine("File Apened");

            //Get Last Access Time
            Console.WriteLine(File.GetLastAccessTime("C:\\Files\\Hi.txt"));


            //Get Last Written time
            Console.WriteLine(File.GetLastWriteTime("C:\\Files\\Hi.txt"));


            //Move File
            if (File.Exists("C:\\Files\\Hi.txt"))
                File.Delete("C:\\Files\\Hi.txt");
            File.Move("C:\\source\\source.txt" , "C:\\Files\\Hi.txt");
            Console.WriteLine("File Moved");

            //Copy File
            File.Copy("C:\\source\\copy.txt", "C:\\Files\\Hi.txt");
            Console.WriteLine("File Copied");

            //Read File
            object read = File.ReadAllText("C:\\Files\\Hi.txt");
            Console.WriteLine(read);

            //Delete File
            File.Delete("C:\\Files\\Hi.txt");
            Console.WriteLine("File Delete"); 

            Console.ReadLine();

        }
    }
}
