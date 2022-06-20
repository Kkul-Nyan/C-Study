using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch11
{
    internal class p481a
    {
        class Box
        {
            private int width;
            private int Width
            {
                get { return width; }
                set
                {
                    if (value > 0) { width = value; }
                    else { throw new Exception("너비는 자연수를 입력해주세요"); }
                }
            }
            private int height;
            private int Height
            {
                get { return height; }
                set
                {
                    if(value > 0) { height = value; }
                    else { throw new Exception("높이는 자연수를 입력해주세요"); }
                }
            }

            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int Area() { return this.width * this.Height; }
        }


        static void Main1(string[] args)
        {
            Console.WriteLine("Box클래스 예외 관련 구현");
            Box box = new Box(-10, -20);
        }
    }
}
