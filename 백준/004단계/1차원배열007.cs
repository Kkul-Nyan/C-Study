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
                string[] inputstr = Console.ReadLine().Split();
                int[] points = new int[inputstr.Length];
                for(int k =0 ; k < inputstr.Length; k++)
                {
                    points[k] = int.Parse(inputstr[k]);
                }
                double total = 0;
                for(int j = 1 ; j < points.Length; j++)
                {
                    total += points[j];
                }
                double average = total / points[0];

                double count = 0;
                for (int h = 1; h < inputstr.Length; h++)
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
