using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class String1
    {
        /*
         * Extract and Display the first three characters of an input string. 
         */

        public void displayString()
        {
            string s;
            Console.WriteLine("Enter a string");
            s = Console.ReadLine(); //string user enters is assigned to string object s
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("The string is empty");
            }
            else
            {
                string substr = s.Substring(0, 3);
                Console.WriteLine("Original string is {0}, its length is {1} and its first three charachters are {2}", s, s.Length, substr);
            }

        }
    }
}
