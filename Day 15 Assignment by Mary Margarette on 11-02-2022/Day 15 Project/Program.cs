using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day_15_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hi {0}, Welcome to Margaret {1} Quiz {2}", name, name, score);
            Console.WriteLine("Q1. Who is the music director of Bahubali ?");
            Console.WriteLine("1.S.Thaman  2.A.R.Rahman  3.M.M.Keeravani  4.Anup Rubens");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;
            Console.WriteLine("Q2. who sang Maguva Maguva song from vakeel saab movie ?");
            Console.WriteLine("1.Sid Sriram  2.Sunitha  3.Anup Rubens  4.Revanth");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;
            Console.WriteLine("Q3. Who wrote gelupu thalupule song from Theen maar movie ?");
            Console.WriteLine("1.Chandrabose  2.Ramajogayya Sastry  3.Bhaskarabhatla Ravi Kumar  4.Rahman");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;
            Console.WriteLine("Q4. Who is the music director of pushpa ?");
            Console.WriteLine("1.S.Thaman  2.Devi Sri Prasad  3.M.M.Keeravani  4.Sid Sriram");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
            Console.WriteLine("Q5. Who composed song amma amma from Raghuvaran B.Tech ?");
            Console.WriteLine("1.Rahman  2.Anup Rubens  3.Anirudh Ravichander  4.Devi Sri Prasad");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;
            StreamWriter sw = new StreamWriter("C:\\Files\\quiz.txt");
            sw.WriteLine(name);
            sw.WriteLine(score);
            sw.Close();
            Console.WriteLine("\n\nScore recorded");
            Console.WriteLine("\n\nThank you for attending test");
            Console.ReadLine();
        }
    }
}
