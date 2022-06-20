using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch11
{
    internal class p471
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Finally의 효과");
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
                return; //return의 이용한 종료
            }
            finally //return으로 종료시키려해도 finally는 작동한다.
            {
                Console.WriteLine("프로그램이 종료되었습니다");
            }
        }
    }
}