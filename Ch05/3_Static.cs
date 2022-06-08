using Ch05.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022 /06/08
 * 이름 : 정현기
 * 내용 : 클래스 변수, 클래스 메서드 실습교재 p225 
 *
 * 클래스 변수(정적변수,메서드)
 * - static 변수, Data 영역 메모리 공간에 하나의 클래스 변수로 관리된다.
 * - 클래스 타입(객체 생성X)으로 직접 참조
 * 싱글톤 객체(Singleton)
 * - 싱글톤 객체는 하나의 인스턴스만을 갖도록 보장하는 객체이다.
 * - 싱글톤 객체를 활용해서 메모리 절약과 성능 향상을 기대할수 있다.
 */

namespace Ch05
{
    class Increment
    { 
        public int num1;
        public static int num2;

        public Increment()
        {
            num1++;
            num2++;
            Console.WriteLine("num1 : {0}, num2 : {1}", num1,num2);
        }
        //static : 공유객체. 원래 메모리상 사라져서 1이되지만, static 선언되서 3번 계산되서 3이되버린다.
        //static 메서드 에서는 non-static 변수를 참조할수없다(참조당할수는있다)
        public static void Add()
        {
            
            num2++;

            Console.WriteLine("num2 :"+num2);
        }

    }
    internal class _3_Static
    {
        static void Main1(string[] args)
        {
            Increment inc1 =new Increment();
            Increment inc2 =new Increment();
            Increment inc3 =new Increment();

            //클래스 변수, 클래스 메서드 실행
            Increment.num2 = 10;
            Increment.Add();
            Increment.Add();

            //Car 객체 생성
            Car car1 = new Car("현대차", "검정색", 0);
            Car car2 = new Car("기아차", "흰색", 0);
            Car car3 = new Car("포드차", "노랑색", 0);

            car1.Show();
            car2.Show();
            car3.Show();

            //Calc 객체 생성

            Calc cal1 = Calc.Instance;
            Calc cal2 = Calc.Instance;
            Calc cal3 = Calc.Instance;
            Calc cal4 = Calc.Instance;
            Calc cal5 = Calc.Instance;

            //모두 결국 Calc.Instance 하나에서 가져온다.

           
            int r1 = cal1.Plus(1, 2);
            int r2 = cal2.Minus(1, 2);
            int r3 = cal3.Multi(2, 3);
            int r4 = cal4.Div(4, 2);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);


        }

    }
}
