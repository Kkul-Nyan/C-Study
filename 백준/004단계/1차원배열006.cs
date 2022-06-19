using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//일단 반복 횟수 T를준다 => T만큼 반복하게 for 반복문 1회
//OX를 구분할 반복문
//OX를 O그룹에 숫자를 대입 계산하는 반복문
//OX 한줄에 O그룹을 합치는 반박문
//출력
//  반복횟수 입력받음 / 전체반복 [ OX구분 [ o그룹 총합 [ O그룹 계산 ] 각라인값 출력]]]

//1번계획 실패
//O만 독자적인 그룹 형성 과정 만들기 실패
//X를 int값 초기화 시키게 만들어서 o계산식을 초기화해서 X나올때마다 1,2,3으로 만들어버리자

namespace 백준._004단계
{
    internal class _1차원배열006
    {
        static void Main1(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());
            int[] Final = new int[t];

            for (int i = 0; i < t; i++) // 전체 반복문
            {
                string[] str = Console.ReadLine().Split();                                                    // OX입력받을 string 그룹
                char[] ch = str[0].ToCharArray();                                                             // 반복횟수 입력받고 OX입력받음 OX char그룹으로 낱개 분할
                             
                int num = 0;
                int [] Onum = new int[ch.Length]; 
                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch[j] == 'X')
                    {
                         num = 0;
                         Onum[j] = 0;
                    }

                    //OOOO     OXOXOXO    OOXOOOXOOOO  OOOOXXXOOXOOOXX
                    //1+2+3+4

                    else
                    {
                        Onum[j] = num + 1;
                        num++;
                    }

                }
                int total = 0;
                for (int H=0; H<Onum.Length; H++)
                {
                    total +=Onum[H];
                }
                
                Final[i] = total;
                
            }
            Console.Clear();
            foreach(int F in Final)
            { Console.WriteLine(F); }
        }
    }
}
