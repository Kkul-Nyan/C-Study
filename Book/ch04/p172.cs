using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p172
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("for반복문과 배열");
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("foreach반복문과 var키워드");

            string[] ray = { "1", "2", "햄스터", "도마뱀", "거북이", "앵무새" };
            
            foreach(var item1 in ray)
            {
                Console.WriteLine(item1);
            }

            Console.WriteLine(ray[0].GetType());
            Console.WriteLine(ray[1].GetType());
            Console.WriteLine(ray[0] + ray[1]);
            int ray1=int.Parse(ray[0]);
            int ray2=int.Parse(ray[1]);
            Console.WriteLine(ray1+ray2);
           
        }
    }
}
