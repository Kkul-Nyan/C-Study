using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p223
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("클래스 파일 빠르게 생성하기");
            Product product = new Product();

        }
    }

    internal class Product
    {
        internal string name;
        internal int price;
    }
}
