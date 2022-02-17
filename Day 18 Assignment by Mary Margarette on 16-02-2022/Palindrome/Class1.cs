using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Class1
    {
        public static string Palin(int n)
        {
            int sum = 0, rem; 
            int temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum* 10 + rem;
                n = n / 10;
            }
            if (temp == sum) 
                return "Palindrome";
            else
                return "Not Palindrome";
        }
    }
}
