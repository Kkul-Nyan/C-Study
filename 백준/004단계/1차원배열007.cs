using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열007
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            double[] final = new double[T];
            for (int i = 0; i < T; i++)
            {
                string[] str = Console.ReadLine().Split();
                double[] points = new double[str.Length];
                for(int k =0 ; k < str.Length; k++)
                {
                    points[k] = int.Parse(str[k]);
                }
                double total = 0;
                for(int j = 1 ; j < points.Length; j++)
                {
                    total += points[j];
                }
                double average = total / points[0];

                double count = 0;
                for (int h = 1; h < str.Length; h++)
                {
                    if (points[h] > average)
                    {
                        count++;
                    }

                }
                double people_age = (count / points[0]) * 100; ;
                
                final[i] = Math.Round(people_age, 3);

            }
            Console.Clear();
            foreach (double k in final)
            {
                Console.WriteLine(k+"%");
            }
        }
    }
}
