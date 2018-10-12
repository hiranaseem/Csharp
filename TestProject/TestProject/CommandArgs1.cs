using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class CommandArgs1
    {

        /*
        *  Demonstrate how the command-line arguments are
        *  passed to it. Display passed arguments on the screen.
        * 
        */

        public void display(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("The supplied command-line arguments are: ");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
            else
            {
                Console.WriteLine("No command-line arguments are supplied");
            }

        }
    }
}

            