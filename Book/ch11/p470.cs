using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch11
{
    internal class p470
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("고급예외처리");
            Console.Write("입력 : ");
            string input = Console.ReadLine();

            try 
            {
                int index = int.Parse(input);
                Console.WriteLine("입력숫자 : "+index);
            }
            catch(Exception exception)
            {
                Console.WriteLine("에외가 발생했습니다");
                Console.WriteLine( exception.GetType());
            }
            
                Console.WriteLine("프로그램이 종료되었습니다");
            
        }
    }
}
