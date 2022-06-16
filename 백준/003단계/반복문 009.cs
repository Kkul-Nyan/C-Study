using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_009
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            Console.Clear();
            for(int i = 1; i < T+1 ; i++)
            {
                int j = 0;
                while (j != i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
            }
        }
    }
}
