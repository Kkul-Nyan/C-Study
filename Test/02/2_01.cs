using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 배열 연습문제
 */
namespace Test
{
    internal class _2_01
    {
        static void Main1(string[] args)
        {
			char[] str = { 'I', ' ', 'L', 'O', 'V', 'E', ' ', 'Y', 'O', 'U' };
			int row, col;

			for (row = 1; row < 10; row++)
			{
				for (col = 0; col < row; col++)
				{
                    Console.Write(str[col]);
				}
				Console.Write("\n");
			}
		}
    }
}
