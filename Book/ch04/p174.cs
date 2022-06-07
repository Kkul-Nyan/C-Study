using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p174
    {
        static void Main1(string[] args)
        {
            for (int i =0; i < 10; i++)
            {
                for(int k=0; k < i+1; k++)
                {
                    var j = "☆";
                    Console.Write(j);
                }
                Console.WriteLine();           
            }
        }
    }
}
