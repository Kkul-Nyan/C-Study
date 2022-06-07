using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p159
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("배열 생성하고 요소에 접근");
            //배열을 생성합니다.
            int[] intArray = { 52, 273, 32, 65, 103 };

            //배열의 요소를 변경합니다.
            intArray[0] = 0;

            //요소를 출력합니다.
            for(int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine();
            Console.WriteLine();

            //배열의 길이를 출력합니다
            Console.WriteLine("배열의 Length 속성");
            Console.WriteLine(intArray.Length);

        }
    }
}
