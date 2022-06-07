 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p182
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("대문자화와 소문자화");
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
            //문자열 자체가 바뀌는건 아님. 단지 Console.WriteLinn에서만 잠시 바뀐것뿐임


        }
    }
}
