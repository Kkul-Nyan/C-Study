using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch11
{
    internal class p475
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("예외객체에서 정보 추출");
            Console.Write("입력 : ");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);
                Console.WriteLine("입력숫자 : " + index);
            }
            catch (Exception exception)
            {
                Console.WriteLine("에외가 발생했습니다");
                Console.WriteLine(exception.GetType());
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}