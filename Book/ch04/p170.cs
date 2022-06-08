using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p170
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("역 for반복문");
            //배열을 생성합니다

            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            for(int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
