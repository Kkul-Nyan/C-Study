using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p95
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("후위 증감 연산자");

            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number); number += 1;
            Console.WriteLine(number); number -= 1;
            Console.WriteLine(number);
        }
    }
}
