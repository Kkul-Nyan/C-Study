using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_007
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] nums = new int[T];
            for(int i = 0; i < T ; i++)
            {
                string[] str = Console.ReadLine().Split();
                nums[i] = int.Parse(str[0])+int.Parse(str[1]);
            }
            Console.Clear();   
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Case #{i+1}: " + nums[i]);
            } 
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Case #"+(i+1)+": " + nums[i]);
            }
        }
    }
}
