using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_010
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i < T + 1; i++)
            {
                for(int j= T; j > i; j-- )
                {
                    Console.Write(" ");
                }
                for(int k= 0; k < i ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}