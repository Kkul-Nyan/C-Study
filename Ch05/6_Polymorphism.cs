using Ch05.Sub5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/09
 * 이름 : 정현기
 * 내용 : 다형성 실습하기 교재 p.340
 * 다형성
 *  - 상속관계에서 부모 클래스의 기능이 자식 클래스에서 여러 기능으로 변하는 특성
 *  - 생성된 객체의 타입선언을 부모 클래스 타입으로 선언
 */


namespace Ch05
{
    internal class _6_Polymorphism
    {
        static void Main1(string[] args)
        {
            //객체생성
            Tiger tiger = new Tiger();
            Eagle eagle = new Eagle();
            Shark shark = new Shark();
            
            Animal tiger1 = new Tiger(); 
            Animal eagle1 = new Eagle();
            Animal shark1 = new Shark();       
            
            Animal a1 = new Tiger();
            Animal a2 = new Eagle();
            Animal a3 = new Shark();

            //기본적으로 override를 선언하지 않아서 하이딩이기때문에 animal로 잡으면 그냥 숨겨진 animal이 나온다
            //move는 하이딩 move1은 오버라이드
            tiger.Move();
            eagle.Move();
            shark.Move();
            
            tiger1.Move();
            eagle1.Move();
            shark1.Move();    
            
            a1.Move();
            a2.Move();
            a3.Move();

            (tiger1 as Tiger).Hunt();
            (eagle1 as Eagle).Hunt();
            (shark1 as Shark).Hunt();

            //객체타입 캐스팅
            Tiger tigerA = (Tiger)a1;
            Eagle eagleA = (Eagle)a2;
            //Eagle eagle3 = a2 as Eagle;
            Shark sharkA = (Shark)a3;


            tigerA.Hunt();
            eagleA.Hunt();
            sharkA.Hunt();

            //객체 타입 확인
            if (a1 is Tiger)
            {
                Console.WriteLine("a1은 Tiger입니다.");
            }
            else { Console.WriteLine("a1은 animal입니다"); }
            if (a2 is Eagle)
            {
                Console.WriteLine("a2은 Eagle입니다.");
            }
            else { Console.WriteLine("a2은 animal입니다"); }
            if (a3 is Shark)
            {
                Console.WriteLine("a3은 Shark입니다.");
            }
            else { Console.WriteLine("a3은 animal입니다"); }
           
            Console.WriteLine();     
           
            tiger.Move1();
            eagle.Move1();
            shark.Move1();
            
            tiger1.Move1();
            eagle1.Move1();
            shark1.Move1();

            a1.Move1();
            a2.Move1();
            a3.Move1();

     

        }
    }
}
