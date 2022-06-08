using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    class Test
    {
        public int Power(int x)
        {
            return x * x;
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("인스턴트 메서드 생성과 사용");
            Test test = new Test();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
        }



    }
}
