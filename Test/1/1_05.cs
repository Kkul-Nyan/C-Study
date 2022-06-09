using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/09
 * 이름 : 정현기
 * 내용 : 다형성 실습하기 교재 p.340
 */
namespace Test._1
{
    internal class _1_05
    {
        static void Main1(string[] args)
        {
            string strScroe = "60,72,82,86,92";
            string[] score = strScroe.Split(","); //,로 분리한다
            
            int total = 0;

            for (int i = 0; i < score.Length; i++)
            {
                total += int.Parse(score[i]); 
            }
            Console.WriteLine("총점 : " + total);
        }
    }
}
