using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class SplitSentence
    {
        public void displaySentence()
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] str = sentence.Split(' '); // store sentence in the array
            Console.WriteLine("The words in the sentence are: ");
            foreach (string s in str)
            {
                Console.WriteLine(s);
            } 
        }
    }
}
