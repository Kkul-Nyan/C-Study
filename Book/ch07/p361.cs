using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p361
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public new string variable = "hiding";
            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("new메서드를 사용한 하이딩, 그러나 안해도 이름겹치면 자동 하이딩되버림");
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
        }
    }
}
