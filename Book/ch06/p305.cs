using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p305
    {
        class Program
        {
            class Test
            {
                public int value = 10;
            }

            static void Change(Test input)
            {
                input.value = 20;
            }
            static void Main1(string[] args)
            {
                Console.WriteLine("간단한 참조 복사 예");
                Test testA = new Test();
                Test testB = testA;
                testA.value = 10;
                testB.value = 20;
                Console.WriteLine(testA.value);

            }
        }

    }
}


