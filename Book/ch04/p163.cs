using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p163
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("while 반복문 이용"+"\n"+"\n");

            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번쨰출력" + intArray[i]);
                i++;
            }
            

        }
    }
}
