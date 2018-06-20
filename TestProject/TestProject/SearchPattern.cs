using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class SearchPattern
    {
        public void stringDisplay()
        {
            string s1, s2;
            int n;
            Console.WriteLine("Enter a string");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter pattern to search");
            s2 = Console.ReadLine();
            n = s1.IndexOf(s2);
            if(n!=-1)
            {
                Console.WriteLine("The pattern {0} is found in {1}  at location {2}", s2, s1, n + 1);
            }
            else
            {
                Console.WriteLine("The pattern {0} is not found in {1}", s2, s1);
            }
        }
    }
}
