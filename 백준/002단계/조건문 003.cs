using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._002단계
{
    internal class 조건문_003
    {
        static void Main1(string[] args)
        {
            string str1 = Console.ReadLine();

            int A = int.Parse(str1);
            int B = A % 4;
            int C = A % 100;
            int D = A % 400;

            if (B == 0 && C == 0 && D == 0)
            {
                Console.WriteLine("1");
            }

            else if(B == 0 && C != 0 )
            {
                Console.WriteLine("1");
            }
                    
                    
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
