using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch09
{
    internal class p443
    {
        static void Main1(string[] args)
        {
            //파일에 문자열 쓰기
            Console.WriteLine("파일 읽기");
            File.WriteAllText(@"C:\test\test.txt", "문자열을 파일에 씁니다");
            Console.WriteLine(File.ReadAllText(@"C:\test\test.txt"));
         
        }
    }
}