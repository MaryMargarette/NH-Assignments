using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hi{0}, Welcome to Margaret Quiz", name);
            Console.WriteLine("Q1. Who is the music director of Bahubali ?");
            Console.WriteLine("1.S.Thaman  2.A.R.Rahman  3.M.M.Keeravani  4.Anup Rubens");
            Console.WriteLine("Enter your choice:");
            ans=Convert.ToInt32(Console.ReadLine());
            if(ans == 3)
                score +=20;
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
            if (score >= 60)
                Console.WriteLine("Congrats {0}, You got {1}% in the quiz", name, score);
            else
                Console.WriteLine("Sorry {0}, you got{1}%, Try Again", name, score);
            Console.ReadLine();
        }
    }
}
