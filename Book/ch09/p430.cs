using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch09
{
    internal class p430
    {
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose() 메서드를 호출합니다");
            }
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Dispose 메서드 호출하기");
            Dummy dummy = new Dummy();
            dummy.Dispose();
        }
    }
}
