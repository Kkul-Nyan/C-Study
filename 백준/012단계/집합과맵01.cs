using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question
{
    internal class 집합과맵01
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int j = 0; j < T; j++)
            {
                string[] str = Console.ReadLine().Split();

                Console.WriteLine("Case #" + (j + 1) + ": " + "" + int.Parse(str[0]) + " + " + int.Parse(str[1]) + " = " + (int.Parse(str[0]) + int.Parse(str[1])));
            }
        }
    }
}