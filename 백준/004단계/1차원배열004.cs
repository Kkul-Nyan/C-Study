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
            int[] nums = new int[10]; 
            for(int v = 0; v < 10; v++)
            {
                nums[v] = int.Parse(Console.ReadLine()) % 42;
            }
            
            int F = 1;

            for (int i = 0; i < nums.Length-1; i++)
            {
                for(int j = i+1 ; j < nums.Length; j++)
                {
                    if( nums[i] > nums[j])
                    {
                        int tram = nums[j];
                        nums[j] = nums[i];
                        nums[i] = tram;
                    }
                }
            }

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    F++;
                }
            }
            Console.Clear();
            Console.WriteLine(F);
        }
    }
}
