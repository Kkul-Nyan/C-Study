using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p348
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
            }
        }

        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("일반적인 자료형 변환");
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Dog(), new Cat()
            };


            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }



            }
        }
    }
}
