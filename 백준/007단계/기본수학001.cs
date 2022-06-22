using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._007단계
{
    internal class 기본수학001
    {
        class Breakpoint
        {


            public int x;
            public int y;
            public int z;
            public int n;

 

            public void number()
            {
                string[] A = Console.ReadLine().Split();
                int[] nums = new int[A.Length];
                for(int i = 0; i < nums.Length; i++)
                {
                    nums[i] = int.Parse(A[i]);
                }
                x = nums[0]; y = nums[1]; z = nums[2];
                
            }

            public void breakpoint()
            {
                n = (x / (z - y)+1);
                if (n<0)
                { n = -1; }
                Console.WriteLine(n);
            }

        }
        static void Main1(string[] args)
        {

            Breakpoint bp = new Breakpoint();
            bp.number();
            bp.breakpoint();

        } 
    }
}
