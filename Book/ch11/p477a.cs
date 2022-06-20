using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch11
{
    internal class p477a
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("예외객체를 사용한 예외 구분");
            Console.WriteLine("고급 예외 처리");
            Console.WriteLine("입력 : ");
            try
            {
                string input = Console.ReadLine();
                int[] array = { 52, 273, 32, 103 };

                int index = int.Parse(input);
                Console.WriteLine("입력 숫자 : " + index);
                Console.WriteLine("배열 요소 : " + array[index]);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("FormatException 발생");
                Console.WriteLine(exception.GetType() + "이 발생했습니다");
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("IndexOutOfRangeException 발생");
                Console.WriteLine(exception.GetType() + "이 발생했습니다");
            }
        }
    }

}