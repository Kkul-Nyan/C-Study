using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/09
 * 이름 : 정현기
 * 내용 : 다이아몬드 출력 연습문제
 */
namespace Test._1
{
    internal class _1_09
    {
        static void Main1(string[] args)
        {
            int count = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (i <= 5)  // 1 2 3 4 5 6 7 8 9 
                    count++; // 1 2 3 4 5 4 3 2 1 
                else         // 1 3 5 7 9 7 5 3 1
                    count--;

                for(int j = 5 ; j > count ; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0 ; k < 2 * count - 1 ; k++)          
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
