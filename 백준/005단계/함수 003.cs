using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._005단계
{
    internal class 함수_003
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();

            for (int i = 1; i <= (t/2); i++)
            {
                for(int j = 1; j <= (t/2); j++)
                {
                    if (t > 0)
                    {
                        t -= i;
                        nums.Add(t);
                    }
                }
                

                
            }






        }
    }
}
