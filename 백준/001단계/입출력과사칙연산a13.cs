using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._001단계
{
    internal class 입출력과사칙연산a13
    {
        static void Main1(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            int C = int.Parse(A);
            int D = int.Parse(B.Substring(0,1));
            int E = int.Parse(B.Substring(1,1));
            int F = int.Parse(B.Substring(2,1));
            int G = int.Parse(B);


            Console.WriteLine(C*F);   
            Console.WriteLine(C*E);
            Console.WriteLine(C*D);
            Console.WriteLine(C*G);

           
        }
    }

}
