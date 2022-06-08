using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p292
    {
       class Product
        {
            private static int count;
            public readonly int id;     //readonly 키워드를 지정 = 읽기전용 변수로 만들어준다. svm에서 변경불가 변경시도시 오류
            public string name;
            public int price;

            public Product(string name, int price)
            {
                id = count++; //생산자에서는 readonly 키워드를 적용한 변수를 변경할 수 있다.
                this.name = name; 
                this.price = price;
            }

            public void Show()
            {
                Console.WriteLine("=============================");
                Console.WriteLine("이름은 : "+name);
                Console.WriteLine("가격은 : "+price);
                Console.WriteLine("id는 ㅣ " + id);
                Console.WriteLine("=============================");

            }
        }
        static void Main1(string[] args)
        {
            Product product = new Product("과자", 1000);
            //product.id = 10; readonly 때문에 오류발생 변경불가
            Product product1 = new Product("빼빼로", 500);
            Product product2 = new Product("눈깔사탕", 100);
            Product product3 = new Product("담배", 4500);
            Product product4 = new Product("건전지", 2000);
            Product product5 = new Product("아이스크림", 1500);
            Product product6 = new Product("껌", 600);
            Product product7 = new Product("터보라이터", 1100);
            product.Show();
            product1.Show();
            product2.Show();
            product3.Show();
            product4.Show();
            product5.Show();
            product6.Show();
            product7.Show();
        }
    }
}
