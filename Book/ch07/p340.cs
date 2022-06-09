using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p340
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
            Console.WriteLine("코드중복");
            List<Dog> Dogs = new List<Dog>();
            List<Cat> Cats = new List<Cat>();

            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();

            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();

            }
            //비슷한 구문의 반복 list반복, foreach반복 변수가 늘어날수록 반복은 반복된다.

        }
    }
}
