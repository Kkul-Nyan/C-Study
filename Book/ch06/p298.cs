using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p298
    {
        class Box
        {
            //getter setter를 따로 선언할필요없이 변수를 선언할떄 변수의 속성으로 넣어버린다
            private int width;
            public int Width //속성 Width  생성
            {
                get { return width; }
                set
                {
                    if (value > 0) { width = value; }
                    else { width = Math.Abs(value); }
                }
            }
            private int height;
            public int Height //속성 Height 생성
            {
                get { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { height = Math.Abs(value); }
                }
            }

            //생성자
            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }
            //인스턴트 메서드

            public int Area() 
            { 
                return this.width * this.height; 
            }

        }

        static void Main1(string[] args)
        {
            Console.WriteLine("일반적인속성(겟터,섹터 간략화)");
            Box Box1 = new Box(10, 20);
            Box1.Area();
            Console.WriteLine(Box1.Area());
                Box1.Width = -200;
                Box1.Height = -100;
            Box1.Area();
            Console.WriteLine(Box1.Area());
        }
    }
}
