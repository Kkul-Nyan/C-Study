using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class p131
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("홀수 짝수 구분하기");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("숫자입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }
            else
            {
                Console.WriteLine("짝수입니다!");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("오전과 오후 구분하기"+"\n");

            if(DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
