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
            String1 s = new String1();
            String2 s2 = new String2();
            StringConcat s3 = new StringConcat();
            StringCompare s4 = new StringCompare();
            SearchPattern s5 = new SearchPattern();
            Palindrome s6 = new Palindrome();
            StringArray s7 = new StringArray();
            SplitSentence s8 = new SplitSentence();
            DuplicateNumberInArray dup = new DuplicateNumberInArray();

            int[] arr = { 5, 6, 8, 8, 5 };
            dup.findDuplicateNum(arr);
            //r.DisplayNum();
            //o.DisplyOneDimArray();
            //t.displayTwoDimArray();
            //s8.displaySentence();
            
            Console.ReadKey();
        }
    }
}
