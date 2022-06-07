using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p178
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("goto 키워드");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부반복문");
                    goto doNotUse;
                }
            }
        doNotUse:
            Console.WriteLine("goto 키워드");
        }
    }
}
