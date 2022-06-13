using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열003
    {
        static void Main(string[] args)
        {
            //A*B*C=D
            //D값에 0~9까지 쓰인 숫자 카운드 D= 1000 0:3 1:1

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            int A = int.Parse(num1);
            int B = int.Parse(num2);
            int C = int.Parse(num3);
            //D의 숫자를 나누어서 배열로 만들기
            Console.Clear();
            int D = A * B * C;
            string Total = D.ToString();
            //D 배열을 카운트
            


        }
    }
}