using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            //Console.WriteLine("Hello World!");
            RectClass r = new RectClass();
            OneDimArray o = new OneDimArray();
            TwoDimArray t = new TwoDimArray();
            //r.DisplayNum();
            //o.DisplyOneDimArray();
            t.displayTwoDimArray();
            Console.ReadKey();
        }
    }
}
