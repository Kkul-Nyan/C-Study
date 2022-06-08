using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p160
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("IndexOutRangeException 배열의 범위를 넘어간 인덱스에 접근");
            int[] intArray = { 52, 273, 32, 65, 103 };

            //요소의 길이를 출력합니다.
            Console.WriteLine(intArray[4]);
            //같이 인덱스 범위를 넘어가서 지정된게 없으면 IndexOutRangeException오류가 생긴다.
        }
    }
}
