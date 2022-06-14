using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열004
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            int num7 = int.Parse(Console.ReadLine());
            int num8 = int.Parse(Console.ReadLine());
            int num9 = int.Parse(Console.ReadLine());
            int num10 = int.Parse(Console.ReadLine());
            int[] nums = { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10 };
            int[] K = new int[nums.Length];
            int Total = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                K[i] = nums[i] % 42;
            } 
            //1 2 3 4 5 6 7 8 9 10
            //0 1 2 3 4 5 6 7 8 9

  
        }
    }
}
