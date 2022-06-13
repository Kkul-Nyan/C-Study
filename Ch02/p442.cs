using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    internal class p442
    {
        static void Main1(string[] args)
        {
            //파일에 문자열 쓰기
            File.WriteAllText(@"C:\test\test.txt", "문자열을 파일에 씁니다");
        }
    }
}
