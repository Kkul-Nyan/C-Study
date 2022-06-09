using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p351
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }

        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("자식 생성자");
            }
        }
        
        static void Main1(string[] args)
        {
            Child child = new Child(); // 자식 인스턴트 생성
            Console.WriteLine("상속했을때 기본적인 생성자 호출순서");
        }

    }
}
