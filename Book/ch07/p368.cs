using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p368
    {
        sealed class Parent
        {
            public void test() { }
        }

        class Child // : Parent -sealed 때문에 상속 거부
        {
            public void test() { }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("sealed 클래스 오류");
            Parent parent = new Parent();
            Child child = new Child();

            parent.test();
            child.test();

        }
    }
}
