using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p370
    {
         class Parent
        {
          //sealed public void test() { }
        }

        class Child  : Parent 
        {
            public void test() { }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("sealed 메서드 오류 -sealed는 메서드에서 오버라이드 하지못하게 막는다");
            Parent parent = new Parent();
            Child child = new Child();

            //parent.test();
            child.test();

        }
    }
}
