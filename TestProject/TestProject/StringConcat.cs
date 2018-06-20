using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class StringConcat
    {
        public void displayString()
        {
            string s1 = "Hello";
            string s2 = "World!";
            Console.WriteLine("The two strings are {0} and {1}", s1, s2);
            s1 += " "; //add a space to s1 --> Hello + " "
            s1 += s2;// Hello + " " + World!
            Console.WriteLine("The string after concatenation is {0}", s1);
        }
    }
}
