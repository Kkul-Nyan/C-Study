using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p273
    {
        public static int Abs(int input)
        {
            if(input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("메서드 생성과 사용");
            Console.WriteLine(Abs(52));
            Console.WriteLine(Abs(-273));
        }
    }
}
