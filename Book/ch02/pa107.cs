using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class pa107
    {
        static void Main1(string[] args)
        {
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            Console.WriteLine("강제 자료형 변환");

            long longNumber = 2147483647L + 2147483647L;
            int intnumber = (int)longNumber;
            Console.WriteLine(intnumber);
        }
    }
}
