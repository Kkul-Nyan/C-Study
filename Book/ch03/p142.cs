using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class p142
    {
        static void Main1(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("삼항연산자");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("참과 거짓 위치에 불 자료형 사용");
            Console.WriteLine();

            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine();

            Console.WriteLine("참과 거짓 위치에 문자열 자료형 사용");
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
        }
    }
}