using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class p143
    {
  
        static void Main1(string[] args)
        {
            //변수를 선언합니다
            int number = int.Parse(Console.ReadLine());

            //조건을 구분합니다.
            Console.WriteLine(number > 0 ? "자연수입니다" : "자연수가아닙니다");

            string A = Console.ReadLine();
            int num = int.Parse(A);
            Console.WriteLine(num > 0 ? "자연수" : "자연수X");
        }
    }
}
