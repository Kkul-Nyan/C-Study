using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class pa115
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("간단한 문자열 변환");
            int number = 52273;
            string outputA = number + "";
            Console.WriteLine(outputA);

            char charactor = 'a';
            string outputB = charactor + "";
            Console.WriteLine(outputB);
        }
    }
}
