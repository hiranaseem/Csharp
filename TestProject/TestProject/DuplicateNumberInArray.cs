using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class DuplicateNumberInArray
    {
        public void findDuplicateNum(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 1; j< arr.Length-1; j++)
                {
                    if(arr[i] == arr[j+1])
                    {
                        count++;
                    }
                }
                Console.WriteLine("\t\n " + arr[i] + " occurs " + count + " times");
            }
            Console.ReadKey();
        }
    }
}
