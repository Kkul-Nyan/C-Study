using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p171
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("foreach 반복문");

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach (int num in intArray)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine("for 반복문");
            
            for (int number = 0; number < intArray.Length; number++)
            {
                Console.WriteLine(intArray[number]);

            }
            


        }
    }
}
