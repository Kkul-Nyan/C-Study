using System;
using System.Threading; //Thread 클래스를 사용하려면 입력해야하는 코드

namespace Book.ch04
{
    internal class p186_1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Thread.Sleep()메서드");
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번쨰 출력");
        }
    }
}
