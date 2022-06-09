using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p339
    {
        class Animal
        {
            private void Private() { }
            protected void Protected() { }
            public void Public() { }

            public void TestA()
            {
                Private();
                Protected();
                Public();
                //자신의 클래스 내부에서는 모든멤버를 사용할수있다
            }
        }

        class Dog : Animal
        {
            public void TestB()
            {
                Protected();
                Public();
            // 상속받은 클래스에서는 private 접근 제한자가 붙은 멤버를 사용 할 수 없다.
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("세 가지 접근제한자");
            Dog dog = new Dog();
            dog.Public();
            //이외의 모든 장소에서는 public 접ㅂ근 제한자가 붙은 멤버만 사용할수 있다.
        }
    }
}
