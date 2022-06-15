using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
{
    internal class p405
    {
        struct Point
        {
            public int x;
            public int y;
        }
        class PointClass
        {
            public int ix;
            public int iy;
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("new 키워드를 사용하지 않고 구조체 인스턴스 생성");
            Point point;
            point.x = 10;
            point.y = 10;

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);

            PointClass class1 = new PointClass();
            //new 선언을 안하면 null 값이 뜬다. class1이 제대로 선언이 안됨.
            class1.ix = 11;
            class1.iy = 11;
            Console.WriteLine(class1.ix);
            Console.WriteLine(class1.iy);
        }
    }
}
