using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/14
 * 이름 : 정현기
 * 내용 : 자주 사용되는 내장클래스 실습하기
 * 
 */

namespace Ch06
{
    internal class _6_internalClass
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////
            //Math 클래스
            ///////////////////////////////////
            //Math math=newMath(); Pow ->제급함수
            Console.WriteLine("PI : " +Math.PI);
            Console.WriteLine("9제곱근 : "+Math.Sqrt(9));
            Console.WriteLine("절대값 : "+Math.Abs(-5));
            Console.WriteLine("올림값 : "+Math.Ceiling(1.2));
            Console.WriteLine("올림값 : "+Math.Ceiling(1.8));
            Console.WriteLine("내림값 : "+Math.Floor(1.2));
            Console.WriteLine("내림값 : "+Math.Floor(1.8));
            Console.WriteLine("반올림 : "+Math.Round(1.2));
            Console.WriteLine("반올림 : "+Math.Round(1.8));
            Console.WriteLine();



            ///////////////////////////////////
            //Random 클래스
            ///////////////////////////////////
            Random random = new Random();

            int rand1 = random.Next();
            Console.WriteLine("rand1 : "+rand1);

            int rand2 = random.Next(10);
            Console.WriteLine("ran2 : "+rand2); //0~9사이의 정수
               
            int rand3 = random.Next(1,11);//1~10사이의 임의의 정수
            Console.WriteLine("ran3 : " + rand3);

            double num1 =random.NextDouble();
            Console.WriteLine("num1 : " + num1);


            double num2 = num1 * 10;
            Console.WriteLine("num2 : " +num2); //0~10사이의 임의이 실수

            double num3 = Math.Ceiling(num2);
            Console.WriteLine("num3 : "+num3);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            ///////////////////////////////////
            //DateTime 클래스
            ///////////////////////////////////
            //싱클톤 객체

            DateTime now = DateTime.Now;

            Console.WriteLine("now : " + now.Year);
            Console.WriteLine("년 : " + now.Month);
            Console.WriteLine("월 : " + now.Day);
            Console.WriteLine("일 : " + now.Hour);
            Console.WriteLine("시 : " + now.Minute);
            Console.WriteLine("초 : " + now.Second);

            //문자열 Format
            string result1 = now.ToString("yyyy-mm-dd");
            Console.WriteLine("result1 : "+result1);

            string result2 = now.ToString("yyyy-mm-dd hh:mm:ss");
            Console.WriteLine("result2 : " + result2);

        }
    }
}
