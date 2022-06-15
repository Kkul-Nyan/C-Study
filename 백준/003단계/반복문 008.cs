using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_008
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            
            int[] number = new int[T];
            int[] number1 = new int[T];

            for (int j = 0; j < T; j++)
            {
                string[] str = Console.ReadLine().Split();
                number[j] = int.Parse(str[0]);
                number1[j] = int.Parse(str[1]);
            }

            Console.Clear();

            for(int i =0; i < T; i++)
            {
                Console.WriteLine("Case #"+(i+1)+": " + ""+number[i]+" + " + number1[i] + " = " + (number[i] + number1[i]));
            }
        }
    }
}
