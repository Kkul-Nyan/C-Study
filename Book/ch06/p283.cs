using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p283
    {
        class Product
        {
            public string name;
            public int price;

            public Product(string name, int price)
            {
                this.name = name;
                this.price = price;
            }
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("기본적인 생산자의 모습");   
        }
    }
}
