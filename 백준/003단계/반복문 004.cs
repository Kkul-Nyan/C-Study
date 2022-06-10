using System;


    internal class 반복문_004
    {
        private static Dictionary<int,long> memo = new Dictionary<int,long>();
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] Num = new int[T];

            for (int i = 0; i < T; i++)
            {
                string[] A = Console.ReadLine().Split();
                Console.WriteLine(int.Parse(A[0]) + int.Parse(A[1]));
            }
        }
    }
