using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p373
    {
        abstract class Parent
        {
            public abstract void Test(); //{ } abstract 메서드이므로 본문을 선언못한다. 자식껄 받아쓴다 
        }

        class Child : Parent
        {
            public override void Test() { Console.WriteLine("child Method"); }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("abstract 메서드와 관련된 오류해결");

            // Parent parent = new Parent(); -> abstract 클래스인 Parent는 직접 인스턴트 생성 X
            Child child = new Child();

            //parent.test();
            child.Test();

        }
    }
}
