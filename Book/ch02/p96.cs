using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p96
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("증감 연산자 이해도 확인");

            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("여러 줄로 나누어 적은 증감 연산자");
            int num = 10;
            Console.WriteLine(num);
            num++;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(num);
            num--;
            num--;
            Console.WriteLine(num);
        }
    }
}
