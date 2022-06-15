using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
{
    internal class p406
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
            Console.WriteLine("구조체의 생성자 - Class와 달리 매개변수없이 생성자를 만들수없다.");
        }
    }
}
