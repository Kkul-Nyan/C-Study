using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
{
    internal class p409
    {
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;
        
            public Point(int x, int y) //생성자 오버로딩 했습니다
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화"; //초기화함 이 생성자와 관련없어도 모든 매개변수를 초기화 해야함.
            }
            public Point(int x, int y, string test) //생성자 오버로딩 했습니다
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화"; 
            }

        }

        static void Main1(string[] args)
        {
            Console.WriteLine("구조체의 초기화 형태");
            Point point = new Point();
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }

    }
}