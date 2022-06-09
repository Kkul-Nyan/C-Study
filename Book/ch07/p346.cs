using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p346
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
        static void Main(string[] args)
        {
            Console.WriteLine("is 키워드");
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Dog(), new Cat()
            };
 
            
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if (item is Dog) { Console.WriteLine("참"); }
                if (item is Cat) { Console.WriteLine("거짓ㄴㄴㄴ"); }            
                


            }
        }
    }
}