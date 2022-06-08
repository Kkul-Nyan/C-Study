using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p89
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("불 변수 생성");
            Console.WriteLine();

            bool one = 10 < 0;
            bool other = 20 > 100;
            bool two = 20 > 10;

            Console.WriteLine("one : " + one);
            Console.WriteLine("other : " + other);
            Console.WriteLine("two : " + two);
            
        }
    }
}
