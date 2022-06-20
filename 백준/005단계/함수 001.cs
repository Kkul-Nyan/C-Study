using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._005단계
{
    internal class 함수_001
    {
        static void Main1(string[] args)
        {
            int n = 1;
            Console.WriteLine(n);
            //int n1 = n + (n / 10) + (n % 10);
            //int n2 = n1 + (n1 / 10) + (n % 10);

            for (int i = 1; i < 10000; i++)
            {
                for (int j = 1; j < 10000; j++)
                {
                    if (j < 10)
                    {
                        i = j + (j % 10);
                    }

                    else if (j > 9 && j < 100)
                    {
                        i = j + (j / 10 % 10) + (j % 10);
                    }

                    else if (j > 99 && j < 1000)
                    {
                        i = j + (j / 100 % 10) + (j / 10 % 10) + (j % 10);
                    }
                    else if (j > 999 && j < 10000)
                    {
                        i = j + (j / 1000 % 10) + (j / 100 % 10) + (j / 10 % 10) + (j % 10);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                }

            }

        }
    }
}
