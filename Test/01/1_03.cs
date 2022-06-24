using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 연산자 연습문제
 */
namespace Test
{
    internal class _1_03
    {
        static void Main3(string[] args)
        {
			int x = 4;
			int y = -2;
			int z;

			z = x + y;
            Console.WriteLine("x + y = " + z);

			z = x - y;
			Console.WriteLine("x - y = " + z);

			z = x * y;
			Console.WriteLine("x * y = " + z);

			z = x / y;
			Console.WriteLine("x / y = " + z);

			z = (x + y) * (x - y);
			Console.WriteLine("(x + y) * (x - y) = " + z);
		}
    }
}
