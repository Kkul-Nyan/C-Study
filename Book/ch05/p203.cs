using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p203
    {

        class car
        {
            int carNumer;
            int inTime;
            int outTime;
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("간단한 객체지향이 나온이유");

            car[] cars = new car[10];

            Console.WriteLine("현재는 간단하므로 자료형으로 만들면 되지만, 복잡한 자료형들이 나오게 되면, 메서드로 따로 별도관리하는것이 편하게된다.");

        }
    }
}
