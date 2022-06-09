using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p352
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
            public Child() :base() //base 키워드를 사용
            {
                Console.WriteLine("자식 생성자");
            }
        }

        static void Main1(string[] args)
        {
            Child child = new Child(); // 자식 인스턴트 생성
            Console.WriteLine("base 키워드를 사용한 생산자 지정 -1");
        }

    }
}