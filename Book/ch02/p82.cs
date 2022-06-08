using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p82
    {
        public static void Main2(string[] args)
        {
            int a = 2000000000;
            int b = 1000000000;

            Console.WriteLine("오버플로우");
            Console.WriteLine("a + b");
            Console.WriteLine(a + b +"\n" + "\n");


            Console.WriteLine("자료형 변환을 사용한 해결 방법 3가지");
            Console.WriteLine("1.unsigned 자료형");
            Console.WriteLine("unsigned 자료(부호가없는자료)인 uint, ulong을 int, long 대신 사용");

            uint unsignedInt = 4147483647;
            ulong unsighedLong = 11223372036854775808;

            Console.WriteLine("unsignedInt : "+unsignedInt);
            Console.WriteLine("unsighedLong : "+unsighedLong);




        }
    }
}
