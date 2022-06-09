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
 */

namespace Ch05
{
    internal class _6_Polymorphism
    {
        static void Main(string[] args)
        {
            //객체생성
            Tiger tiger = new Tiger();
            Eagle eagle = new Eagle();
            Shark shark = new Shark();
            
            Animal tiger1 = new Tiger(); //여러개 붙을수있을까? 예를들어 공격적 호랑이, 약한호랑이
            Animal eagle1 = new Eagle();
            Animal shark1 = new Shark();       
            
            Animal a1 = new Tiger();
            Animal a2 = new Eagle();
            Animal a3 = new Shark();
            //기본적으로 override를 선언하지 않아서 하이딩이기때문에 animal로 잡으면 그냥 숨겨진 animal이 나온다
            tiger.Move();
            eagle.Move();
            shark.Move();
            
            tiger1.Move();
            eagle1.Move();
            shark1.Move();    
            
            a1.Move();
            a2.Move();
            a3.Move();

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
