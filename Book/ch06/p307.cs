using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p307
    {
        class Fibonacci
        {
            public long Get(int i)
            {
                if (i < 0) { return 0; } //종료조건
                if(i == 1) { return 1; } //종료조건
                 return Get(i - 2) + Get(i - 1);
            }

        }
        class Program
        {
            static void Main1(string[] args)
            {
                Console.WriteLine("재귀메서드를 사용한 피보나치 인스턴스 메서드");
                Fibonacci fibo = new Fibonacci();
                Console.WriteLine(fibo.Get(1));
                Console.WriteLine(fibo.Get(2));
                Console.WriteLine(fibo.Get(3));
                Console.WriteLine(fibo.Get(4));
                Console.WriteLine(fibo.Get(5));
            }
        }
    }
}
