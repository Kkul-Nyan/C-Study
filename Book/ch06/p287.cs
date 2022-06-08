using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p287
    {
        class Sample
        {
            public static int value;

            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생산자 호출");
            }
            static void Main1(string[] args)
            {
                Console.WriteLine("정적 생산자");
                Console.WriteLine("정적 생산자의 호출 시점" + "\n");
                Console.WriteLine("첫 번쨰 위치");
                Sample sample = new Sample();
                Console.WriteLine("두 번째 위치");
                Console.WriteLine(Sample.value); //이때 한번만 호출됨
                Console.WriteLine("세 번째 위치");
            }

        }

    }
}
