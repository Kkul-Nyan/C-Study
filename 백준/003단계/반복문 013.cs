using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_013
    {
        static void Main1(string[] args)
        {
            int i = 0;
            while (true)
            {
                string s = Console.ReadLine();
                if (s == null)
                { break; }
                string[] str = s.Split();
                int A = int.Parse(str[0]); int B = int.Parse(str[1]);
                int C = A + B;
                Console.WriteLine(C);
            }
        }
    }
}