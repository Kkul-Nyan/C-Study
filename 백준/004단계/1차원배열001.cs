using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열001
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            int a = int.Parse(A);
            string[] B = Console.ReadLine().Split();
            int[] b = Array.ConvertAll(B, int.Parse);

            int max = -1000000;
            int min = 1000000;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] > max)
                {
                    max = b[i];
                }
                if(b[i] < min)
                {
                    min = b[i];
                }    
            }
            Console.WriteLine(min + " " + max);
        }
    }
}
