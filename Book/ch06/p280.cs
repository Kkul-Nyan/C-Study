using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p280
    {
        class Test
        {
            public void TestMethod()
            {
                //Program.Main(new string[] { "" });
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Console.WriteLine("Main()메시드를 호출했으나 접근제한자가 private이므로 접근할수 없음");
            }
        }
    }
}
