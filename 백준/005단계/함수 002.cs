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
            int k = 0;
            int n = 1;
            //int n1 = n + (n / 10) + (n % 10);
            //int n2 = n1 + (n1 / 10) + (n % 10);
            while ( n < 10000)
            {
                if (n < 10)
                {
                     k= n+ (n % 10);
                    Console.WriteLine(k);

                }

                else if (n>9 && n < 100)
                {
                    k = n + (n / 10 % 10) + (n % 10);
                    Console.WriteLine(k);

                }

                else if (n>99 && n < 1000)
                {
                    k = n + (n/100 %10)+(n/10%10)+(n%10);
                    Console.WriteLine(k);

                }
                else
                {
                    k = n + (n / 1000 % 10) +(n / 100 % 10) + (n / 10 % 10) + (n % 10);
                    Console.WriteLine(k);
                }

                n++;
            }
        
        }
    }
}
