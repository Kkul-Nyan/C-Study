using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class pa103
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("long 자료형을 나타내는 기호 : 소문자"); //1과 구분 힘드니 소문자X
            Console.WriteLine(123456 + 65432l);
            Console.WriteLine();

            Console.WriteLine("long 자료형을 나타내는 기호 : 대문자");
            Console.WriteLine(123456 + 65432L);
        }
    }
}
