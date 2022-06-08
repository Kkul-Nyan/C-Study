using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p210
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("원하는 범위의 실수 난수 생성");
            Random random = new Random();
            Console.WriteLine(random.NextDouble()*10);
            Console.WriteLine(random.NextDouble()*10);
            Console.WriteLine(random.NextDouble()*10);
            Console.WriteLine(random.NextDouble()/10);
        }
    }
}
