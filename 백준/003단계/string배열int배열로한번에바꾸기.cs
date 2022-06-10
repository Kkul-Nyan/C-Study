using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class string배열int배열로한번에바꾸기
    {
        static void Main1(string[] args)
        {
            string[] A = Console.ReadLine().Split();
            int[] B = Array.ConvertAll(A, int.Parse);
            Console.WriteLine(B[0]);
            Console.WriteLine(B[1]);
            Console.WriteLine(B[2]);
        }
    }
}