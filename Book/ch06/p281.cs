using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p281
    {
        class Program
        {
            class Test
            {
                public void TestMethod()
                {
                   // Program.Main(new string[] { "" });
                }
            }

            public void TestMethod()
            {
               // Program.Main(new string[] { "" });
            }

            static void Main1(string[] args)
            {
                Console.WriteLine("위의 경우 같은 내부 클래스이기 때문에 접근이 가능하다");
                Console.WriteLine("밑의 경우 아까와 다르게 지금은 class Program 내부에 Main이 있기 때문에 Program에서는 Main에 접근 가능하다.");
            }
        }
    }
}
