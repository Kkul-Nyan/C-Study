using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
{
    internal class p407
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("매개변수가 없는 생성자로 구조체의 인스턴트를 생성하고 출력하니 생성자에서 자동으로 초기화해서 출력한다");
            Point point = new Point();
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }

    }
}
