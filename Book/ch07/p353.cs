using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p353
    {
        class Parent
        {
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }
        }

        class Child : Parent
        {
            public Child() : base(10) //Parent(int param)부모 생성자를 호출합니다.
            {
                Console.WriteLine("Child : base(10)");
            }

            public Child(string param) : base("input") //Parent(string param)부모 생성자를 호출합니다.
            {
                    Console.WriteLine("Child(string input) : base(input)");
            }
        }

        static void Main1(string[] args)
        {
            Child childA = new Child(); 
            Child childB = new Child("string");
            Console.WriteLine("base키워드를 사용한 생산자 지정");
            Console.WriteLine("base로 표시한 부모 생성자가 호출되는것을 확인가능");
        }

    }
}