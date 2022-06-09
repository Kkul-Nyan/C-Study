using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p373_스스로만들어본_abstract
    {
        abstract class Animal
        {
            public abstract void Eat();
            public virtual void Sound()
            {
                Console.WriteLine("동물의 울음소리~~~~~~~~~~~~~~~~~~~~~");
            }
         
        }

        class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("강아지 사료를 먹습니다");
            }
            public new void Sound()
            {
                Console.WriteLine("멍멍멍멍멍멍멍멍멍멍멍멍멍멍");
            }
        }

        class Cat : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("고양이 사료를 먹습니다");
            }
            public override void Sound()
            {
                Console.WriteLine("야옹야옹야옹야옹야옹야옹야옹");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("new 키워드를 사용한 경우 - Dog 하이딩, Cat 오버라이드 ");

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sound();
            }
        }
    }
}
