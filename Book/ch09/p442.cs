using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09
{
    internal class p442
    {
        static void Main1(string[] args)
        {
            //파일에 문자열 쓰기 @기호를 사용한 문자열(Verbatim String : 축자문자열)
            File.WriteAllText(@"C:\test\test.txt", "문자열을 파일에 씁니다");

        }
    }
}
