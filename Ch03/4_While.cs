using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 정현기
 * 내용 : 반복문 while 실습하기 교재 p162
 */

namespace Ch03
{
    internal class _4_While
    {
        static void Main1(string[] args)
        {
            //1부터 10까지의 합

            Console.WriteLine("초기식");
            Console.WriteLine("while(조건식)");
            Console.WriteLine( "{증감식}");

            int sum = 0;
            int k = 1;

            while (k<=10)
            {
                sum += k;
                k++;
            }
            Console.WriteLine("1부터 10까지 합 : "+sum);

            //dowhile while의 증감식을 위로 올린것 뿐이다. 증감식이 먼지 나중에 조건식이니 무조건 1번은 실행한다.

            int total = 0;
            int i = 1;

            do
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
                    i++;
            } while (i<=10);
            Console.WriteLine("1부터 10까지의 짝수합 : "+total);

            //break 무한 반복문안에 조건을 넣어 종료시킴

            int num = 1;
            while(true)
            {
                if(num % 5==0 && num%7==0)
                    {
                    break;
                    }
                num++;
            }
            Console.WriteLine("5와 7의 최소 공배수 : "+num);


            //continue 증감식안에 조건이 나오고 조건이 맞으면 밑에 안보고 위로올려버림

            int tot = 0;
            int j = 0;
            while (j <=10)
            {
                j++;
                if (j%2==1)
                {
                    continue; //반복문의 처음으로 이동
                }

                tot += j;


            }
            Console.WriteLine("1부터 10까지 짝수합 : "+tot);

        }
    }
}
