using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p372
    {
        abstract class Parent
        {
       //     public abstract void test() { } 
        }
        // 메서드를 abstract하기 위해선 클래스도 abstract여야한다. abstract클래스는 무조건 abstract메서드만 가지는건 아니다. 자식이 하이딩으로 쓸수있기때문임. 하지만 abstract 메서드는 무조건 abstract클래스안에서만 생성된다.
        class Child  : Parent 
        {
            public void test() { }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("abstract 메서드 오류");
        //    Parent parent = new Parent();
            Child child = new Child();

        //    parent.test();
            child.test(); // -> abstract 메서드를 오버라이드하지않아 생긴 오류

        }
    }
}
