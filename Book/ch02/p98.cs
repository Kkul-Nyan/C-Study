using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p98
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("GetType()메서드 활용");
            //변수를 선언
            int _int = 273;
            long _long = 522731033265;
            double _double = 52.273;
            float _float = 52.273F;
            string _string = "문자열";
            char _char = '글';

            //출력
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_string.GetType());
            Console.WriteLine(_char.GetType());
        }
    }
}
