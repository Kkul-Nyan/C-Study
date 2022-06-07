using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._002단계
{
    internal class 조건문_005
    {
        static void Main1(string[] args)
        {
            string[] A = Console.ReadLine().Split();
            

            int C = int.Parse(A[0]);
            int D = int.Parse(A[1]);


            int E = (C * 60) + D;
            int H = (E - 45) / 60;
            int M = (E - 45) % 60;
            
            if (E > 44)
            {
                Console.WriteLine(H + " " + M);
            }

            else
            {
                int F = 1440 + E;
                int H1 = (F - 45) / 60;
                int M1 = (F - 45) % 60;
                Console.WriteLine(H1+" "+M1);
            }
        }
    }
}
