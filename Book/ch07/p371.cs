using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p371
    {
        abstract class Parent
        {
            public void test() { }
        }

        class Child  : Parent 
        {
            public void test() { }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("abstract 클래스 오류 -abstract처럼 추상적 개념의 클래스이므로 구체적인 인스턴트는 당연히 직접 생성불가, 상속으로 다른 자식들을 이용해서 생성 ");
            // Parent parent = new Parent();
            Child child = new Child();

            //parent.test();
            child.test();

        }
    }
}
