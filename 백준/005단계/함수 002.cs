using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._005단계
{
    internal class 함수_002
    {
        static void Main(string[] args)
        {
            int n = 1;
            int n1 = n + (n / 10) + (n % 10);
            int n2 = n1 + (n1 / 10) + (n % 10);
            int count = 0;
            while (n >9)
            {
                if(n>10)
                {
                    count++;
                }
                n /= 10;
            }
        
        }
    }
}
