﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/10
 * 이름 : 정현기
 * 내용 : 배열연습문제
 */
namespace Test._2
{
    internal class _2_03
    {
        static void Main1(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //(1,10자리바꾸고, 2,9자리바꾸고 총5번)
            //현재 배열 출력
            for(int i =0; i<10; i++)
            { 
                Console.Write(arr[i]+","); 
            }

            //배열 원소를 역순으로 정렬
            for (int j =0; j<5;j++)
            {
                int temp =arr[j];                     
                arr[j] = arr[9 - j];                   
                arr[9-j] = temp;                       
                                                  
            }
            //역순으로 정렬된 배열 출력
            foreach(int n in arr)
            {
                Console.Write(n +",");
            }
        }
    }
}
