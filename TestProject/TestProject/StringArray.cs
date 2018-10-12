using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class StringArray
    {
        public void displayArray()
        {
            string[] fruits = new string[5];
            Console.WriteLine("Enter the name of five fruits: ");
            //for(int i =fruits.Length-1; i>=0; i--)
            for (int i =0; i<4; i++)
            {
                fruits[i] = Console.ReadLine();
            }

            Console.WriteLine("The elements in the string array are: ");
            foreach(string f in fruits)
            {
                Console.WriteLine(f);
            }
        }
    }
}
