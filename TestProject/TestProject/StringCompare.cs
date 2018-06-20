using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class StringCompare
    {
        public void stringDisplay()
        {
            string s1, s2;
            int n;
            Console.WriteLine("Enter two strings");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            n = s1.CompareTo(s2);
            if (n == 0) Console.WriteLine("The two strings {0} and {1} are equal", s1, s2);
            if (n < 0) Console.WriteLine("The string {0} is smaller than {1} ", s1, s2);
            if (n > 0) Console.WriteLine("The string {0} is greater than {1} ", s1, s2);

        }
    }
}
