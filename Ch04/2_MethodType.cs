using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/07
 * 이름 : 정현기
 * 내용 : 메서드 타입 실습하기 교재 p265
 */


namespace Ch04
{
    internal class _2_MethodType
    {
        static void Main1(string[] args)
        {
            //MEthod 호출
            double y1 = Type1(0.1); //인자값 0.1대입
            double y2 = Type1(1.2);//인자값 1.2대입

            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);

            Type2(true); //리턴값이 없으므로 대입연산자 필요없음
            Type2(false);

            string result = Type3();
            Console.WriteLine("Type3 resulf: "+result);

            Type4();



        }

        //Type1 : 매개변수 O, 리턴 값O)

        public static double Type1(double x)
        {
            double y = x + 3.14;
            return y;
        }

        //Type2 : 매개변수 O, 리턴 값X)
        public static void Type2(bool status) //리턴값이 없을때 void가 들어간다
        {
            if(status)
            {
                Console.WriteLine("참입니다"); 
            }
            else
            {
                Console.WriteLine("거짓입니다");
            }

        }


        //Type3 : 매개변수 X, 리턴 값O)
        public static string Type3()
        {
            int n1 = 1, n2 = 2;

            if(n1 > n2)
            {
                return "n1은 n2보다 크다";
            }
            else
            {
                return "n1은 n2보다 작다";
            }


        }

        //Type4 : 매개변수 X, 리턴 값X)

        public static void Type4()
        {
            double result = Type1(1.121);
            Console.WriteLine("Type4 result : "+result);
        }



    }

}
