using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 문자열 처리 연습문제
 */
namespace Test
{
    internal class _1_05
    {
        static void Main5(string[] args)
        {	
			string strScore = "60,72,82,86,92";
			string[] scores = strScore.Split(",");

			int total = 0;

			for (int i = 0; i < scores.Length; i++)
			{
				total += int.Parse(scores[i]);
			}

            Console.WriteLine("총점 : " + total);
		}
    }
}



