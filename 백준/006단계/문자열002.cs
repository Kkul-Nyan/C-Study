using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._006단계
{
    internal class 문자열002
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int sum = 0;
           
            for (int i =0; i < T; i++)
            {
                sum += int.Parse(str[i].ToString());

            }
            Console.WriteLine( sum);

        }
    }
}
