using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Palindrome
    {
        public void displayPalindrome()
        {
            string s;
            int i, n, e;
            Boolean p = true;
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            n = s.Length;
            e = n - 1; //0 to n-1
            for(i = 0; i < n/2; i++) //split string in half
            {
                if(s[i] != s[e])
                {
                    Console.WriteLine("The string {0} is not a palindrome", s);
                    p = false;
                    break;
                }
                e--;
            }
            if(p)
            {
                Console.WriteLine("The string {0} is a palindrome", s);
            }
        }
    }
}
