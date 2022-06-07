using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p183
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("문자열 자르기");
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { });
            Console.WriteLine(inputs[0]);
            foreach(var item in inputs)
            {
                Console.WriteLine(item);
            }
        }

    }
}
