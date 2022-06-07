using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class pa102
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("var 키워드로 long자료형과 float자료형인 변수 생성");
            var numberA = 100L;   //long형
            var numberB = 100.0;  //double형
            var numberC = 100.0F; //float형

            Console.WriteLine(numberA);
            Console.WriteLine(numberB);
            Console.WriteLine(numberC);
        }
    }
}
