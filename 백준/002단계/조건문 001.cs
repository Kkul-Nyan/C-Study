using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._002단계
{
    internal class 조건문_001
    {
        static void Main1(string[] args)
        {
            string[] A = Console.ReadLine().Split();
            int B = int.Parse(A[0]);
            int C = int.Parse(A[1]);

            if (B > C)
            {
                Console.WriteLine(">");
            }
            else if (B < C)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }

        }
    }
}
