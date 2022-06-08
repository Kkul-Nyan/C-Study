using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._001단계
{
    internal class 입출력과사칙연산a12
    {
        static void Main1 (string[] args)
        {
            string[] n = Console.ReadLine().Split();
            int A = int.Parse(n[0]);
            int B = int.Parse(n[1]);
            int C = int.Parse(n[2]);

            Console.WriteLine((A+B)%C);
            Console.WriteLine(((A%C)+(B%C))%C);
            Console.WriteLine((A*B)%C);
            Console.WriteLine(((A%C)*(B%C))%C);
        }
    }
}
