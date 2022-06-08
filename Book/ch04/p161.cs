using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p161
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("특정한 크기의 배열 생성");

            //배열을 생성합니다.
            int[] intarray = new int[100];

            //요소의 길이를 출력합니다.
            Console.WriteLine(intarray[0]);
            Console.WriteLine(intarray[99]);


            int[] i = new int[3];
            i[0] = 1;
            i[1] = 2;
            i[2] = 3;
            //i[3] = 4;
            //i[4] = 5; i[]지정범위를 넘어가므로 새로 더 범위가 넒어지는게 아니라 오류가 생기게 된다

            Console.WriteLine(i[0]);
            Console.WriteLine(i[1]);
            Console.WriteLine(i[2]);
            //Console.WriteLine(i[3]);
            //Console.WriteLine(i[4]);

        }
    }
}
