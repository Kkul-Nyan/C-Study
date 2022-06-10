using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열003
    {
        static void Main(string[] args)
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

            int[] nums = { a1, a2, a3, a4, a5, a6, a7, a8, a9 };
            for( int i =0; i < nums.Length-1; i++)
            {
                for(int j =i+1; j<nums.Length ;j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int tram = nums[j];
                        nums[j] = nums[i];
                        nums[i] = tram;
                            
                    }
                }
            }
            Console.WriteLine(nums[8]);
            Console.WriteLine("8");
          

        }   
    }
}
