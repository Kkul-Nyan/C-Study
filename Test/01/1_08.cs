using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 피라미드 출력 연습문제
 */
namespace Test
{
    internal class _1_08
    {
        static void Main8(string[] args)
        {
			int n = 5;

			for (int i = 0; i < n; i++)
			{

				for (int j = n - 1 ;  j > i ; j--)
				{
                    Console.Write(" ");
				}

				for (int k = 0 ; k < 2* i + 1 ; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
		}
	}
}


