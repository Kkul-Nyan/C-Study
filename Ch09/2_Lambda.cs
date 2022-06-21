using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/21
 * 이름 : 정현기
 * 내용 : 람다 실습하기 p500
 * 
 * 람다식(lambda)
 * - 함수적 프로그래밍을 지원하기위한 문법 식
 * - 대리자를 조금 다 간편하게 사용하기 위한 식(익명 메서드)
 */

namespace Ch09
{
    internal class _2_Lambda
    {
        static void Main1(string[] args)
        {
            //반환이 있는 람다식(Func 대리자)
            Func<string> f1 = () => { return "f1 실행"; };
            var f2 = () => { return "f2 실행"; };

            Func<int, string> f3 = (x) => { return "f3x : " + x; };
            Func<int, int, string> f4 = (x,y) => { return $"f4 x:{x}, y:{y}"; };


            string r1 =f1();
            string r3 =f3(3);
            string r4 =f4(3,4);


            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);

            //반환이 없는 람다식(Action 대리자)
            Action           a1 = ()     => { Console.WriteLine("a1 실행"); };
            Action<int>      a2 = (x)    => { Console.WriteLine("a2 x :"+x); };
            Action<int, int> a3 = (x, y) => { Console.WriteLine($"a3 x = {x}, y = {y}"); };

            a1();
            a2(3);
            a3(3, 4);

            //람다식 활용
            List<int> dataset = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            dataset.ForEach((n) => { Console.WriteLine(n + " "); });
        }
    }
}
