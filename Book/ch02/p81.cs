using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p81
    {
        public static void Main2(string[] args)
        {
            int a = 2147483640;
            int b = 52273;

            Console.WriteLine("오버플로우");
            Console.WriteLine("a + b");
            Console.WriteLine(a + b);

            //양수 2147535913이 나와야 하지만 오버플로우 되어 -2147431383이 나온다
            //최대 숫자를 넘어서 제일 낮은 숫자부터 다시 세어서 올라간다.
        }
    }
}
