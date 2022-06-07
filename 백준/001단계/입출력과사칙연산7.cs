using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._001단계
{
    internal class 입출력과사칙연산7
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);

            Console.WriteLine(A*B);
        }
    }
}
