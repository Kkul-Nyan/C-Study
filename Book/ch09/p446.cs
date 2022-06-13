using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch09
{
    internal class p446
    {
        static void Main1(string[] args)
        {
            using(StreamReader reader = new StreamReader(@"C:\test\test.txt"))
            {
                Console.WriteLine("using 구문에서 StreamReader 클래스의 인스턴스 생성");
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
