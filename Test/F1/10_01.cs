using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.F1
{
    class Box
    {
        private double width;
        private double height;
        private double depth;

        public Box(double width, double height, double depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public double volume()
        {
            return width * height * depth;
        }

    }
    internal class _10_01
    {
        static void Main1(string[] args)
        {
            Box box1 = new Box(10, 20, 30);
            Box box2 = new Box(3, 6, 9);

            Console.WriteLine("box1 부피 : "+box1.volume());
            Console.WriteLine("box2 부피 : "+box2.volume());

        }

    }
}
