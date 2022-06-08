using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p293
    {
        class Box
        {
            public int width;
            public int height;

            public Box(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public int Area()
            {
                return this.width * this.height;
            }
        }

        static void Main1(string[] args)
        {

            Console.WriteLine("BOX클래스"+"\n" + "\n");
            Box box1 = new Box(5, 10);
            Box box2 = new Box(1, 10);
            Box box3 = new Box(10, 4);
            Box box4 = new Box(265, 53);
            Console.WriteLine(box1.Area()); 
            Console.WriteLine(box2.Area()); 
            Console.WriteLine(box3.Area()); 
            Console.WriteLine(box4.Area());
            Console.WriteLine();
        }
    }
}
