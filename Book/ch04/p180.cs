using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p180
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("같지만 다른방법");
            for (int j = 1; j < 10; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
