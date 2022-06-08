using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._002단계
{
    internal class 조건문_007
    {
        static void Main1(string[] args)
        {
            string[] random = Console.ReadLine().Split();

            int A = int.Parse(random[0]);
            int B = int.Parse(random[1]);
            int C = int.Parse(random[2]);

            if (A==B && B==C && A==C)
            {
                int All = 10000 + A * 1000;
                Console.WriteLine(All);
            }
            else if (A==B && A != C)
            {
                    int case1 = 1000 + A * 100;
                    Console.WriteLine(case1);
            }
            else if (B == C && A != B)
            {
                    int case2 = 1000 + B * 100;
                    Console.WriteLine(case2);
            }
            else if (A == C && B != C )
            {
                    int case3 = 1000 + C * 100;
                    Console.WriteLine(case3);
            }
            else
            {
                if (A > B && A > C)
                {
                    int case4 = A * 100;
                    Console.WriteLine(case4);
                }
                else if (B > A && B > C)
                {
                    int case5 = B * 100;
                    Console.WriteLine(case5);
                }
                else
                {
                    int case6 = C * 100;
                    Console.WriteLine(case6);
                }
            }
        }   
    }
}
