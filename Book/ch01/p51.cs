using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch1
{
    internal class p51
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("   Write와 Writeline 한줄씩 교차비교" + "\n"); //write가 먼저
            Console.Write("Write");
            Console.WriteLine("Writeline" + "\n");

            Console.WriteLine("Writeline");
            Console.WriteLine("Writeline" + "\n");

            Console.Write("Write");
            Console.Write("Write" + "\n");
        }

    }
}
