using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p91
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("숫자와 관련된 복합 대입 연산사");
            Console.WriteLine();

            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine("output  :  "+output);
            Console.WriteLine();
            Console.WriteLine();
            int output1 = 0;
            output1 = output1 + 52;
            output1 = output1 + 273;
            output1 = output1 + 103;

            Console.WriteLine("output  :  " + output);


        }
    }
}
