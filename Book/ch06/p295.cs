using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p295
    {
        class Box
        {
            private int width;
            private int height;

            public Box(int width, int height)
            {
                if (width > 0 && height > 0)
                {
                    this.width = width;
                    this.height = height;
                }
                else
                {
                    Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
                    this.width = Math.Abs(width);
                    this.height = Math.Abs(height);
                }
            }

            public int Area()
            {
                return this.width * this.height;
            }
            // Getter
            public int GetWidth() { return width; }
            public int GetHeight() { return height; }

            // Setter
            public void SetWidth(int width)
            {
                if (width > 0) { this.width = width; }
                else { this.width = Math.Abs(width); }
            }
            public void SetHeight(int height)
            {
                if (height > 0) { this.height = height; }
                else { this.height = Math.Abs(height); }
            }

            static void Main1(string[] args)
            {

                Console.WriteLine("BOX클래스" + "\n" + "\n");
                Console.WriteLine("캡슐화");
                Console.WriteLine("겟터와 셋터");
                Console.WriteLine("생성자를통한 캡슐화는  객체를 만들떄 예외가 생기지않게 만드는것이고, 겟터와세터는 생성자의 값을  변수를 통해 변경할때 예외가 생기지 않도록 방지하는것이다. 즉, 캡슐화 객체 생성시 보호, 게터세터는 수정시 보호이다");
                Box box1 = new Box(5, -10);
                Box box2 = new Box(-1, 10);
                Box box3 = new Box(10, 4);
                Box box4 = new Box(-265, -53);
                Console.WriteLine(box1.Area());
                Console.WriteLine(box2.Area());
                Console.WriteLine(box3.Area());
                Console.WriteLine(box4.Area());
                Console.WriteLine();
            }
        }
    }
}