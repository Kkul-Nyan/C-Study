using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class p145
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("입력 받아 조건 분할");
            Console.WriteLine();

            Console.WriteLine("입력");
            string line = Console.ReadLine();

            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
            }
            else
            { 
                Console.WriteLine("^^"); 
            }
        }
    }
}
