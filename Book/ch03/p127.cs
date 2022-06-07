using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class p127
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("홀수 짝수 구분");
            Console.WriteLine("\n"+ "\n");

            Console.Write("숫자입력 : ");
            int input = int.Parse(Console.ReadLine());

            if(input % 2 ==0)
            {
                Console.WriteLine("짝수입니다!");
            }
            if(input % 2 !=0)   
            {
                Console.WriteLine("홀수입니다!");
            }
        }
    }
}
