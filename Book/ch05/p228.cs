using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    class ProductA
    {
        public string name = "default";
        public int price= 100;
    }

    internal class p228
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("클래스 변수 생성과 동시에 초기화");
            ProductA productA = new ProductA() { name = "감자", price = 2000 };
            ProductA productB = new ProductA() { name = "고구마", price = 3000 };
            ProductA productC = new ProductA();
            Console.WriteLine(productA.name + " : " + productA.price);
            Console.WriteLine(productB.name + " : " + productB.price);
            Console.WriteLine(productC.name + " : " + productC.price);
        }
    }
}
