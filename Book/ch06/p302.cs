using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p302
    {
        class program
        {
            static void Change(int input)
            {
                input = 20;
            }

            static void Main1(string[] args)
            {
                Console.WriteLine("값 복사 예1 a가 input에 들어가 10이되어 input=20에 input a =10 =20이 된다해도 뒤에적용되는 imput=20에 의해 input=20인것은 변함없음.콘솔(a)에서도 void에서도 알수있다싶이 반환되는값이없고, a를 변화시킬 값이없으므로 그대로 나온다 다라서 10");
                int a = 10;
                Change(a);
                Console.WriteLine(a);
                int b = 10;
                int input = b;
                input = 20;
                Change(b);
                Console.WriteLine(b);
            
            }

        }

    }
}
