using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{      

    internal class Test
    {
        static void Main21(string[] args)
        {            

            Console.WriteLine("{0:N2}", 1234.5678);
            Console.WriteLine("{0:D8}", 1234);
            Console.WriteLine("{0:F3}", 1234.56);
            Console.WriteLine("{0,8}", 1234);
            Console.WriteLine("{0,-8}", 1234);
            Console.WriteLine();

            Console.WriteLine(1234.5678.ToString("N3"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));
            Console.WriteLine();

            Console.WriteLine("{0:#.##}", 1234.5678);


        }
    }
}
