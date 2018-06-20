using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class TwoDimArray
    {
        public void displayTwoDimArray()
        {
            int[,] p = new int[2,4];
            int i, j;
            Console.WriteLine("Enter elements for an array of order 2 x 4");

            //Two for loops for both positions
            for(i=0; i<=1; i++)//for position 2
            {
                for(j=0; j<=3; j++)
                {
                    p[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Display contents of two dimensional array
            Console.WriteLine("\nThe elements in th two dimensional array are: ");
            for(i=0; i<=1; i++)
            {
                for(j=0; j<=3; j++)
                {
                    Console.Write(p[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
