using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p359
    {
        class Parent
        {
            public int variable = 273;
        }

        class Child : Parent
        {
            public string variable = "shadowing";
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("하이딩으로 숨겨진 부모 변수 꺼내쓰기");
            Child child = new Child();
            Console.WriteLine(((Parent)child).variable);
        }
    }
}
