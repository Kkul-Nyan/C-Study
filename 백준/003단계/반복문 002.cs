using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_002
    {
        static void Main(string[] args)
        {
           int T = int.Parse(Console.ReadLine());
            int i = 0;

            while (i < T)
            {
               string[] S = Console.ReadLine().Split();
               int K = int.Parse(S[0]);
               int C = int.Parse(S[1]);
               int D = K + C;
                Console.WriteLine(D);
                i++;
            }
        }
    }
}

