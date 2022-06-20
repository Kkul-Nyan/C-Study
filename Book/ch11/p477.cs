using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch11
{
    internal class p477
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("예외객체를 사용한 예외 구분");
            Console.WriteLine("예외상황 확인");
            Console.WriteLine("입력 : ");
            string input = Console.ReadLine();
            int[] array = { 52, 273, 32, 103 };

            int index =int.Parse(input);
            Console.WriteLine("입력 숫자 : "+index);
            Console.WriteLine("배열 요소 : " + array[index]);
        }
    }
}
