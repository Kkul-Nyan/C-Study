using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p342
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
            Console.WriteLine("다형성을 사용한 코드 중복 해결");
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Dog(), new Cat()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
            }
            //비슷한 구문의 반복 list반복, foreach반복 변수가 늘어날수록 반복은 반복된다.
            //따라서 Animal로 통합해서 단순화 시킨다.
        }
    }
}
