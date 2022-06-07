using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/03
 * 이름 : 정현기
 * 내용 : 조건문 실급교재 p127
 */

namespace Ch03
{
    internal class _1_If
    {
        static void Main1(string[] args)
        {
            //if
            int num1 = 1;
            int num2 = 2;

           /*1*/ if(num1<num2)
                Console.WriteLine("num1은 num2보다 작다");
                Console.WriteLine();

           /*2*/ if (num1 < 1)
            {
                Console.WriteLine("num은 1보다 크다");
            }

            /*3*/ if (num1>0)
            {
                if (num2>1)
                {
                    Console.WriteLine("num1은 0보다 크고, num2는 1보다 크다");
                }
            }

            /*4*/if (num1>0 && num2>1)
            { 
                Console.WriteLine("위에 조건과 똑같다");
                Console.WriteLine();
            }
            //3과 4는 결국 동일하다.


            //if ~ else 조건이 참이면 if 거짓이면 else

            int var1 = 1;
            int var2 =2;

            if (var1>var2)
            {
                Console.WriteLine("var1은 var2보다 크다");
            }
            else 
            {
                Console.WriteLine("var1은 var2보다 작다");
                Console.WriteLine();
            }


            //if ~ else if ~ else

            int n1 = 10, n2 = 20, n3 = 30, n4 = 40;

            if (n1>n2)
            {
                Console.WriteLine("n1은 n2보다 크다");
            }
            else if (n2>n3)
            {
                Console.WriteLine("n2은 n3보다 크다");
            }
            else if (n3>n4)
            {
                Console.WriteLine("n3은 n4보다 크다");
            }
            else
            {
                Console.WriteLine("n4가 가장크다");
            }
            
        }
    }
}
