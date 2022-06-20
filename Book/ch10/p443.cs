using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch10
{
    internal class p443
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("출력및 다시 읽어들이기");
            File.WriteAllText(@"C:\test\test.txt", "문자열을 파일에 씁니다.");
            Console.WriteLine(File.ReadAllText(@"C:\test\test.txt"));
        }
    }
}

