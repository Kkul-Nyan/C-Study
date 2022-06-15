using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
{
    internal class p399
    {
        class SquareCalculator
        {
            public int this[int i]
            {
                get
                { return i * i; }
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Console.WriteLine("인덱서로 배열처럼 사용하는 제곱클래스");
                SquareCalculator square = new SquareCalculator();
                Console.WriteLine(square[10]);
            }
        }

    }
}
