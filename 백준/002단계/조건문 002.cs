using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._002단계
{
    internal class 조건문_002
    {
        static void Main1(string[] args)
        {
            string str1 = Console.ReadLine();

            int A = int.Parse(str1);

            if (A > 90)
            {
                Console.WriteLine("A");
            }
            else if (90 > A && A > 79)
            {
                Console.WriteLine("B");
            }
            else if (80 > A && A > 69)
            {
                Console.WriteLine("C");
            }
            else if (70 > A && A > 59)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
