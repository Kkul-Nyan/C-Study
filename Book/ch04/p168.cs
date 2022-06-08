using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p168
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("for반복문으로 곱샘");
            int output = 1;

            for(int i=1; i<=20;i++)
            {
                output *= i;
                Console.WriteLine(output);
            }
            Console.WriteLine(output);
            Console.WriteLine("한글 전부 출력");

            for(int a='가'; a<='힣'; a++)
            {
                Console.Write((char)a);
            }
        }
    }
}
