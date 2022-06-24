using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 조건문, 반복문 연습문제
 */
namespace Test
{
    internal class _1_07
    {
        static void Main7(string[] args)
        {
			int total = 0;

			for (int k = 1; k<=10 ; k++)
			{

				if (k % 2 == 0 || k % 3 == 0)
				{
					total += k;
				}
			}
            Console.WriteLine("1 ~ 10까지 2와 3배수의 정수의 합 : " + total);
		}
	}
}
