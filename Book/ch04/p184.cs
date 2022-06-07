using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p184
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("문자열 양 옆의 공백제거");
            string input = "         test       \n";
            Console.WriteLine(input );
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();
        }
    }
}
