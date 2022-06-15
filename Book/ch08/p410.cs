using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
{
    internal class p410
    {
        class Program
        {

            struct Point
            {
                public int x;
                public int y;
                public Program program;

                public Point(int x, int y) 
                {
                    this.x = x;
                    this.y = y;
                    this.program = null; //null로 초기화함. 클래스로 불려가든, 생성자를 만들든 , 사용할려면 무조건 초기화
                }
            }

            static void Main1(string[] args)
            {
                Console.WriteLine("구조체에서 인스턴스를 멤버변수로 선언");
                Point point = new Point();
                Console.WriteLine(point.x);
                Console.WriteLine(point.y);
                Console.WriteLine(point.program);
            }
        }
    }
}