using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p189
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while반복문과 괄호사용");
            int i = 10;
            while((i--) > 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
