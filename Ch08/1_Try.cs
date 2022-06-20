using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/20
 * 이름 : 정현기
 * 내용 : 예외처리 실습하기 교재 p467
 * 
 */

namespace Ch08
{
    class Apple
    {
        public void Show()
        {
            Console.WriteLine("Apple Show...");
        }
    }



    internal class _1_Try
    {

        static void Main1(string[] args)
        {
            /////////////////////////
            //try-catch
            /////////////////////////
            //상황1 : 어떤수를 0으로 나눌때 -> 에러

            int num1 = 1;
            int num2 = 0;


            int rs1 = 0,
                rs2 = 0,
                rs3 = 0,
                rs4 = 0;
            
            try //예외가 발생할수 있는 코드
            {
                rs1 = num1 + num2;
                rs2 = num1 - num2;
                rs3 = num1 * num2;
                rs4 = num1 / num2;  //rs4rk 여기서 선언되면 try의 지역변수가 되어 밑에 console.writeline에서 참조를 못한다. 따라서 밖에서 선언하고 try에서는 참조를 이용해서 처리한다.
            }
            catch(Exception e) //예외가 발생 했을때 처리할 코드
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("rs 1 : "+rs1);
            Console.WriteLine("rs 2 : "+rs2);
            Console.WriteLine("rs 3 : "+rs3);
            Console.WriteLine("rs 4 : "+rs4);

            
            //상황2 : 배열의 인덱스 범위를 벗어났을 때
            
            int[] arr = { 1, 2, 3, 4, 5, };


            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i] + " "); //for전체를 안잡고 스파크가 생기는 이부분만 잡아도된다.
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //상황3: null 포인트 에러

            Apple a1 = new Apple();
            Apple a2 = null;
            
            try
            {
                a1.Show();
                a2.Show();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /////////////////////////
            //try-catch-fianally
            /////////////////////////

            try
            {
                //예외가 발생할 가능성이 있는코드
                Console.WriteLine("try...");
            }
            catch
            {
                // 예외가 발생했을때 처리코드
                Console.WriteLine("catch...");
            }
            finally
            {
                // 예외발생 여부와 상관없이 무조건 처리되어야 하는 코드
                Console.WriteLine("finally...");
            }


            Console.WriteLine("프로그램 종료...");
        }

    }
}
