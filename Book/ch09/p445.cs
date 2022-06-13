using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch09
{
    internal class p445
    {
        static void Main1(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\test\test.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("StreamWriter 클래스를 사용해");
                writer.WriteLine("글자를 여러 줄 입력해봅시다");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }
            }
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));
        }

    }
}
