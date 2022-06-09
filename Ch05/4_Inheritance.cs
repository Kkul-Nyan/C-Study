using Ch05.Sub4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 정현기
 * 내용 : 클래스 상속 실습하기 교재 p331
 *
 * 상속
 *  - 기존 클래스의 속성과 기능을 그대로 파생 클래스에 물려줘서 클래스를 확장하는 문법
 *  - 공통적인 내용을 부모클래스에 두고 자식 클래스에서 상속 받아 일관성있고 효율적인 프로그래밍 수행
 */

namespace Ch05
{
    class Parent 
    {
        private int num1;
      
        
        private int num2;

        public Parent(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int Plus()
        {
            return num1 + num2;
        }
    }

    class Child : Parent  // (자식):(부모)방식으로 부모가 자식에게 상속해주는걸 표현해준다.
    {// 속성을 초기화해줘야한다. 부모 속성의 base를 실행하는것
        private int num3;
        private int num4;
      //        원래 num3,4만 있지만 부모식을 사용하기위해 부모식의 num1,num2를 사용하기위해 가져와준다.
        public Child(int num1, int num2,int num3, int num4) : base(num1, num2)
        {
            this.num3 = num3;
            this.num4 = num4;

        }
        public int Minus()
        {
            return num3 - num4;
        }
    }



    internal class _4_Inheritance
    {
        static void Main1(string[] args)
        {
            //상속받은 객체 생성      //어제 연결한데(컨트롤+.)로 들고오면되지 왜 굳이 상속으로 복잡하게 넣어야할 변수가 늘어나게 가져오는가?
            Child c1 = new Child(1,2,3,4);
            Child c2 = new Child(10,20,30,40);

            Console.WriteLine("c1 Plus : "+ c1.Plus());
            Console.WriteLine("c1 Minus : " + c1.Minus());
            Console.WriteLine("c2 Plus : " + c2.Plus()); 
            Console.WriteLine("c2 Minus : " + c2.Minus());

            //Car 상속객체 생성
            Sedan sedan = new Sedan("그랜저", "검정색", 0, 2000);
            Truck truck = new Truck("봉고", "흰색", 0, 1);

            sedan.SpeedUp(40);
            sedan.Show();

            truck.SpeedUp(70);
            truck.Show();
            Console.WriteLine();
            Console.WriteLine();

            //Account 상속 객체 생성
            StockAccount kb = new StockAccount("KB증권", "123-12-1234", "김유신", 1000, "삼성", 0, 0);
            kb.Deposit(1000000);
            kb.buy(10, 70000);
            kb.sell(5, 75000);
            kb.Show();
        }
    }
}
