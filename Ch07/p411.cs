using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07
{
    internal class p411
    {
        class Program
        {
            class PointClass
            {
                public int x;
                public int y;

                public PointClass(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }
            }

            struct PointStruct
            {
                public int x;
                public int y;

                public PointStruct(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }
            }
            static void Main(string[] args)
            {
                //클래스
                PointClass pointClassA = new PointClass(10, 20);
                PointClass pointClassB = pointClassA;
                
                pointClassA.x = 100;
                pointClassA.y = 200;

                Console.WriteLine("pointClassA : "+pointClassA.x+","+pointClassA.y);
                Console.WriteLine("pointClassB : "+pointClassB.x+","+pointClassB.y);
                Console.WriteLine();

            }
        }
    }
}
