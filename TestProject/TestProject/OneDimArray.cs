using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class OneDimArray
    {
        public void DisplyOneDimArray()
        {
            int[] p = new int[10];
            int i;
            Console.WriteLine("Enter ten numbers: ");
            //Enter numbers into array
            for(i=0; i<9; i++)
            {
                p[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            //Print array at postion i
            Console.WriteLine("\nThe numbers entered in the array are");

            for (i = 0; i < 9; i++)
            {
                Console.WriteLine(p[i]);
            }

            Console.ReadKey();
        }
    }
}
