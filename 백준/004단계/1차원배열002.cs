using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열002
    {
        static void Main1(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            int a5 = int.Parse(Console.ReadLine());
            int a6 = int.Parse(Console.ReadLine());
            int a7 = int.Parse(Console.ReadLine());
            int a8 = int.Parse(Console.ReadLine());
            int a9 = int.Parse(Console.ReadLine());
            int[] A = { a1, a2, a3, a4, a5, a6, a7, a8, a9 };
            int[] B = new int[A.Length];
            for (int f = 0; f < A.Length; f++)
            {
                B[f] = A[f];
            }
            for (int i = 0; i < B.Length - 1; i++)
            {
                for (int j = i + 1; j < B.Length; j++)
                {
                    if (B[i] > B[j])
                    {
                        int tram = B[j];
                        B[j] = B[i];
                        B[i] = tram;
                    }
                }
            }
            Console.WriteLine(B[8]);
            int D = B[8];
            for (int p = 0; p < A.Length; p++)
            {  
                if (A[p] == D)
                {
                    Console.WriteLine(p+1);
                }
            }
        }
    }
}
