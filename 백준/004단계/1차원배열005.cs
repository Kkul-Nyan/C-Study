using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열005
    {
        static void Main1(string[] args)
        {
            int StartNum = int.Parse(Console.ReadLine());

            string[] str = Console.ReadLine().Split();
            double[] num = new double[str.Length];
    
            for (int i = 0; i < str.Length; i++)
            {
                num[i] = int.Parse(str[i]);
            }

            for(int i = 0; i < num.Length-1; i++)
            {
                for(int j= i+1; j<num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        double tram = num[j];
                        num[j] = num[i];
                        num[i] = tram;
                    }
                }
            }
            double total = 0;
            double max = num[num.Length - 1];


            for (int i= 0; i < num.Length; i++)
            {
               total += (num[i] / max * 100);
            }
            double k = total / (num.Length);
            Console.WriteLine(k);
        }
    }
}
 