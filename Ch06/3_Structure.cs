using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/14
 * 이름 : 정현기
 * 내용 : 구조체 실습하기 교재 p404
 * 
 * 구조체(Structure)
 *  - 간단하게 객체를 만들때 사용하는 구조 형식
 *  - 클래스와 동일하지만 몇가지 제한( 상속 X, 캡슐화 X-private선언안됨)
 */

namespace Ch06
{
    struct MyPoint  //클래스로 해도된다. 
    {
        public int X;
        public int Y;

        public MyPoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        //필드(속성) 출력 메서드 ToString()
        public override string ToString()
        {
            return String.Format($"X : {X}, Y: {Y}");
        }
    }

    internal class _3_Structure
    {
        static void Main1(string[] args)
        {
            MyPoint p1;
            p1.X = 10;
            p1.Y = 20;

            Console.WriteLine("p1 : "+p1.ToString());

            MyPoint p2 = new MyPoint(20, 30);
            Console.WriteLine("p2 : "+p2.ToString());
        }
    }
}
