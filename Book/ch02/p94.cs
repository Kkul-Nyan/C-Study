using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p94
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("증감연산자의 전위와 후위");
            Console.WriteLine();

            int number = 10;
            Console.WriteLine("number   : " + number);
            Console.WriteLine("number++ : " + number++);
            Console.WriteLine("number-- : " + number--);
            Console.WriteLine("number   : " + number);

            int num = 10;
            Console.WriteLine("num      : "+ num);
            Console.WriteLine("++num    : "+ ++num);
            Console.WriteLine("--num    : "+ --num);
            Console.WriteLine("num      : "+ num);

        }
    }
}
