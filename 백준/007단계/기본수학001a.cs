using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._007단계
{
    internal class 기본수학001a
    {
        static void Main1(string[] args)
        {
            string[] A = Console.ReadLine().Split();
            long[] nums = new long[A.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = long.Parse(A[i]);
            }
            long n = 0;

            if (nums[1] >= nums[2])
            {
                n = -1; 
            }
            else
            {
                n = (nums[0] / (nums[2] - nums[1]) + 1);
            }
            Console.WriteLine(n);
        } 
    }
}