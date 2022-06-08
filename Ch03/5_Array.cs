using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/07
 * 이름 : 정현기
 * 내용 : 배열 실습하기 교재 p157
 */


namespace Ch03
{
    internal class _5_Array
    {
        static void Main(string[] args)
        {
            ///////////////////////
            ///배열기본
            ///////////////////////

            //배열(Array)
            int[] arr1 = new int[3]; //new intdml []에 []부분은 데이터 갯수
            
            arr1[0] = 1;
            arr1[1] = 2;   
            arr1[2] = 3;
            //배열출력
            Console.WriteLine("arr1 1번째데이터 : " + arr1[0]);
            Console.WriteLine("arr1 2번째데이터 : " + arr1[1]);
            Console.WriteLine("arr1 3번째데이터 : " + arr1[2]);
            Console.WriteLine();


            for (int i = 0; i < 3; i++)
            { 
                Console.WriteLine("arr1 {0}번째데이터 : {1}", i + 1, arr1[i]);
            }
            Console.WriteLine();
            
            
            //배열 생성 초기화 //배열이나 리스트에서는 복수형으로 사용
            int[] nums = { 1, 2, 3, 4, 5 };
            char[] chars = { 'a','b','c'};
            string[] cities = { "서울", "대전", "대구", "부산", "광주" };

            //배열 길이
            Console.WriteLine("nums 길이 : "+nums.Length);
            Console.WriteLine("chars 길이 : "+chars.Length);
            Console.WriteLine("cities 길이 : "+cities.Length);
            Console.WriteLine();

            //배열 반복문  nums 길이만큼 반복
            foreach(int num in nums)
            {
                Console.Write(num+"");
            }
            Console.WriteLine();

            foreach(char c in chars)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();

            foreach(string city in cities)
            {
                Console.Write(city+"");
            }
            Console.WriteLine();
            ///////////////////////
            // 다차원배열
            ///////////////////////

            //1차원배열
            int[] arrid = { 10, 20, 30, 40, 50, 60 };

            int total = 0;

           foreach(int num in arrid)
            {
                total += num;
            }
            Console.WriteLine("arr1d 총합 ; "+total);
            Console.WriteLine();

            //2차원배열

            int[,] arr2d = {{ 1, 2, 3, 4 }, 
                            { 5, 6, 7, 8 },
                            { 9, 10, 11, 12 }};


            Console.WriteLine("arr2d[0,0] : " + arr2d[0, 0]);
            Console.WriteLine("arr2d[0,2] : " + arr2d[0, 2]);
            Console.WriteLine("arr2d[1,2] : " + arr2d[1, 2]);
            Console.WriteLine("arr2d[2,3] : " + arr2d[2, 3]);
            Console.WriteLine();

            //3차원배열
            int[,,] arr3d =
                {
                 {
                  { 1, 2, 3},
                  { 4, 5, 6},
                  { 7, 8, 9}
                            },
                 {
                  {10,11,12},
                  {13,14,15},
                  {16,17,18}
                            },
                 {
                  {19,20,21},
                  {22,23,24},
                  {25,26,27}
                            }
                };
            Console.WriteLine("arr3d[0, 0, 2] : " + arr3d[0, 0, 2]);
            Console.WriteLine("arr3d[0, 1, 1] : " + arr3d[0, 1, 1]);
            Console.WriteLine("arr3d[1, 0, 1] : " + arr3d[1, 0, 1]);
            Console.WriteLine("arr3d[1, 2, 1] : " + arr3d[1, 2, 1]);
            Console.WriteLine("arr3d[2, 2, 0] : " + arr3d[2, 2, 0]);
        
        
        }
    }
}
