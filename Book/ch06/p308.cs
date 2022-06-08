using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p308
    {
        class Fibonacci
        {
            public static long Get(int i)
            {
                if(i < 0) { return 0; }
                if(i == 1) { return 1; }
                return Get(i - 2) + Get(i - 1);
            }
        }
        class Program
        {
            static void Main1(string[] args)
            {
                Console.WriteLine("재귀 메서드를 사용한 피보나치 클래스 메서드");
                Console.WriteLine(Fibonacci.Get(1));
                Console.WriteLine(Fibonacci.Get(2));
                Console.WriteLine(Fibonacci.Get(3));
                Console.WriteLine(Fibonacci.Get(4));
                Console.WriteLine(Fibonacci.Get(50));
            }
        }
    }
}
