using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p92
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("문자열과 관련된 복합대입 연산자");
            Console.WriteLine();

            string output = "hello ";
            output += "world";
            output += "!";
            Console.WriteLine("output : "+output);

            string put = "hello  ";
            Console.WriteLine("put : " + put);

            put = put + "world";
            Console.WriteLine("put + \"world\" : " + put);

            put = put + "!";
            Console.WriteLine("put : "+put);
        }
    }
}
