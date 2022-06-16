using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_011
    {
        static void Main1(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int N =int.Parse(str[0]); int X =int.Parse(str[1]);
            
            string[] chars = Console.ReadLine().Split();
            int[] Nums = new int[N];

            for (int i = 0; i < N; i++)
            {
                Nums[i] = int.Parse(chars[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (Nums[i] < X)
                {
                    Console.Write(Nums[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
