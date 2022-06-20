using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
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
            static void Main1(string[] args)
            {
                //클래스
                PointClass pointClassA = new PointClass(10, 20);
                PointClass pointClassB = pointClassA; //참조복사
                
                pointClassA.x = 100;
                pointClassA.y = 200;

                Console.WriteLine("pointClassA : "+pointClassA.x+","+pointClassA.y);
                Console.WriteLine("pointClassB : "+pointClassB.x+","+pointClassB.y);
                Console.WriteLine();

                //구조체(struct)
                PointStruct pointStructA = new PointStruct(10, 20);
                PointStruct pointStructB = pointStructA; //값복사

                pointStructA.x = 100;
                pointStructA.y = 200;

                Console.WriteLine("pointStructA: "+pointStructA.x+","+pointStructA.y);
                Console.WriteLine("pointStructB: "+pointStructB.x+","+pointStructB.y);

            }
        }
    }
}
