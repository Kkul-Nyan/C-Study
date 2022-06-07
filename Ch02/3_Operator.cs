using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/02
 * 이름 : 정현기
 * 내용 : 연산자(Operator) 실습하기 교재 p90
 *  - 변수에 저장된 데이터의 처리를 위해 연산자를 사용
 *  - 연산자는 크게 산술, 증가감소, 복합대입, 비교, 논리 연산자 등이 있다.
 */

namespace Ch02
{
    internal class _3_Operator
    {
        static void Main1(string[] args)
        {
            //산술 연산자
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            int r1 = num1 + num2;
            int r2 = num1 - num2;
            int r3 = num2 * num3;
            int r4 = num4 / num2;
            int r5 = num4 % num3; //나머지

            Console.WriteLine("r1 :" + r1);
            Console.WriteLine("r2 :" + r2);
            Console.WriteLine("r3 :" + r3);
            Console.WriteLine("r4 :" + r4);
            Console.WriteLine("r5 :" + r5 + "\n");




            //증감,감소 연산자
            int num = 0;

            num++;
            ++num;

            Console.WriteLine($"num : {num}");  //문자열 보간 출력

            num--;
            --num;

            Console.WriteLine($"num : {num}" + "\n");



            //복합대입 연산자
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            n1 += 1; // n1 = n1 + 1
            n2 -= 2; // n2 = n2 - 2 
            n3 *= 3; // n3 = n3 * 3
            n4 /= 4; // n4 = n4 / 4
            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");
            Console.WriteLine($"n3 : {n3}");
            Console.WriteLine($"n4 : {n4}" + "\n");


            //비교 연산자
            int var1 = 1;
            int var2 = 2;

            bool rs1 = var1 > var2;
            bool rs2 = var1 < var2;
            bool rs3 = var1 >= var2;
            bool rs4 = var1 <= var2;
            bool rs5 = var1 == var2;
            bool rs6 = var1 != var2;

            Console.WriteLine("rs1 : " + rs1);
            Console.WriteLine("rs2 : " + rs2);
            Console.WriteLine("rs3 : " + rs3);
            Console.WriteLine("rs4 : " + rs4);
            Console.WriteLine("rs5 : " + rs5);
            Console.WriteLine("rs6 : " + rs6 + "\n"); //!=는 ==의 반대

            //논리 연산자
            int val1 = 1;
            int val2 = 2;

            bool res1 = val1 > 1 && val2 > 2; // &&(and) 2개식을 하나로 묶기위해 논리연산을 사용
            bool res2 = val1 > 0 && val2 > 1;
            bool res3 = val1 > 1 || val2 > 2; // ||(or)이다
            bool res4 = val1 > 0 || val2 > 1; // val1이 va2보다 크지않다. 즉 ! 다르다 의미
            bool res5 = !(val1 > val2);

            Console.WriteLine($"res1 : {res1}");
            Console.WriteLine($"res2 : {res2}");
            Console.WriteLine($"res3 : {res3}");
            Console.WriteLine($"res4 : {res4}");
            Console.WriteLine($"res5 : {res5}" + "\n");

            //조건 연산자
            int a = 1;
            // ?,:이 조건 연산자이다 ?앞에 조건(보통식)이 들어가고 :왼쪽에는 참, 오른쪽에는 거짓값일때의 결과값을 넣어준다
            // =() ? "" : "";
            string result = (a > 1) ? "a는 1보다크다" : "a는 1보다 크지않다.";
            Console.WriteLine("result : " + result);
        }
    }
}
