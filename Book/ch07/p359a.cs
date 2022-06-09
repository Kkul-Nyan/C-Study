using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p359a
    {
        class Parent
        {
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("메서드 하이딩");
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
        }

    }
}