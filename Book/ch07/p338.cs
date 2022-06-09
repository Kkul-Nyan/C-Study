using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p338
    {
        class Animal
        {
            protected int Age { get; set; }

            public Animal() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        }

        class Dog : Animal
        {
            public string Color { get; set; }

            public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
            public void Test()
            {
                Eat();
                Sleep();
                //부모와 자식 클래스간에 이름이 겹치면 base.를 이용해서 부모클래스 자식클래스 변수들로 구분할수있다.
            }
        }

        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("부모에게서 상속받은 메서드 호출");

        }
    }
}