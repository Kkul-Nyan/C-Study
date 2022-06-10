using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_004
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());


            for (int i = 0; i < T; i++)
            {
                string[] S = Console.ReadLine().Split();
                int A = int.Parse(S[0]);
                int B = int.Parse(S[1]);
                int C = A + B;
                Console.WriteLine(C);
            }

        }
    }
}
