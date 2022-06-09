using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p289____소멸자_작동안함_모르겠음
    {
        class Program
        {
            class Product
            {
                public string name;
                public int price;
                
                //생성자 
                public Product(string name, int price)
                {
                    this.name = name;
                    this.price = price;
                }
                //
                ~Product()
                { 
                    Console.WriteLine(name +"의 소멸자 호출");
                }
            }

            static void Main(string[] args)
            {
                Product product = new Product("과자", 1000);
            }
        }
    }
}
