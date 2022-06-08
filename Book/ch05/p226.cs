using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p226
    {
        class Product
        { 
            public string name;
            public int price;
           //인스턴스 변수를 생성할때 초기화
            // public string name = "default";
           // public int price = 1000; 
           // 이내용을 class에서 포함시켜도 초기화 되버린다.
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("인스턴트 변수 생성과 사용");
            Product product = new Product();
        }
    }
}
