using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch10
{
    internal class p431
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
            Console.WriteLine("IDisposabel 인터페이스");
            Dummy dummy =new Dummy();
            dummy.Dispose();

        }
    }
}
