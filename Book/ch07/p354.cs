using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p354
    {
        class Parent
        {
            public static int counter = 0;
            public void CountParent()
            {
                counter++;
            }
        }

        class Child : Parent
        {
            public void CountChild()
            {
                Child.counter++;
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("클래스 변수 상속 - 각각 클래스에 소속되어 하나씩 증가되어 1,1 출력으로 예상하지만 클래스변수는 상속되어도 공유되기때문에 2가나온다.");
            Parent parent = new Parent();
            Child child = new Child();  

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}
 