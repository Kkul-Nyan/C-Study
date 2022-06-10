using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_006
    {
        static void Main1(string[] args)
        {   //5 4 3 2 1
            string A = Console.ReadLine();
            int B =int.Parse(A);
            int[] all = new int[B];
            for (int i = B ; i > 0; i--)
            {
                all[i-1] = i;
                Console.WriteLine(all[i-1]);
            }
        }
    }
}
