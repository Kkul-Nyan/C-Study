using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._007단계
{
    internal class why
    {
        class Breakpoint
        {


            public int x;
            public int y;
            public int z;
            public int n;



            public void number()
            {
                int[] nums = { int.Parse(Console.ReadLine().ToString()) };
                x = nums[0]; y = nums[1]; z = nums[2];

            }

            public void breakpoint()
            {
                n = y / (x - z);
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
