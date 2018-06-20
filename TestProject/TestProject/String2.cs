using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class String2
    {
        public void displayString()
        {
            string s;
            int i, n;
            Console.WriteLine("Enter a string: ");
            s = Console.ReadLine();
            Console.WriteLine("The character wise display of the string {0} is ", s);
            n = s.Length;
            for(i=0; i<=n-1; i++)
            {
                Console.WriteLine("{0}", s.Substring(i,1));
            }
        }
    }
}
