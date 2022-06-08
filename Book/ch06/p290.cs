using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p290
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("상수");
            // Math.PI = 20; ->상수로 선언된 변수는 값을 변경할수 없다. 상수는 값을 변경 할수 있는 대상이 아니다는 뜻. 

            int r = 10;
            Console.WriteLine("원의둘레 : "+ (2*Math.PI*r));
            Console.WriteLine("원의넓이 : "+ (Math.PI*r*r));
            Console.WriteLine("변수or 속성 앞에 const 선언으로 상수를 만들수 있다");
            Console.WriteLine("메서드 내부에서 상수를 지정하여 사용할수 있다");
            const int value = 10;

            Console.WriteLine(value);
        }
        class MyMath
        {
            public const double PI = 3.141592;
        }
    }
}
