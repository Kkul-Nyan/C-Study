using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class pa109
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("자동 자료형 변환");

            int intnumber = 2147483647;

            long intToLong = intnumber;
            Console.WriteLine(intToLong);
            double intdouble = intnumber;
            Console.WriteLine(intdouble);


        }
    }
}
