﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p284
    {
        class Product
        {
            public static int counter = 0;
            public int id;  
            public string name;
            public int price;
            

            public Product(string name, int price)
            {
                Product.counter = counter +1;
                this.id = counter;
                this.name = name;
                this.price = price;
            }

            public void show()
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Product.counter = "+ (counter ++));
                Console.WriteLine("id = "+counter);
                Console.WriteLine("name = "+name);
                Console.WriteLine("price = "+price);
                Console.WriteLine("========================================");
            }
        }
        static void Main1(string[] args)
        {
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);


            Console.WriteLine(productA.id + " : " + productA.name);
            Console.WriteLine(productB.id + " : " + productB.name);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");
            productA.show();
            productB.show();
        }
    }
}
