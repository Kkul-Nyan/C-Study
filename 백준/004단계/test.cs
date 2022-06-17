using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class test
    {
        static void Main1(string[] args)
        {
            {
                int count = 10;
                int[] k =new int[count];
                int num = 0;
                
                for (int j = 0; j < count ; j++)
                {
                    num += 1;
                    k[j] = num;
                }
                int total = 0; 
                
                for(int i = 0; i < count ; i++)
                {
                    total += k[i];
                }
                Console.WriteLine(total);
            }
        }

    }
}

