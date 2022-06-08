using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class pa108
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("강제 자료형 변환의 데이터 미손실");

            long longnumber = 52273;
            int intnumber = (int)longnumber;
            Console.WriteLine(intnumber);

            Console.WriteLine("숫자손상");
            //long 자료형을 int 자료형으로 변환합니다

            long Longnumber1 = 2147483647L + 2147484647L;
            int LongToint = (int)Longnumber1;
            Console.WriteLine(LongToint);
            double doubleNumber = 52.27310332;
            int doubleToint = (int)doubleNumber;
            Console.WriteLine(doubleToint);
        }
    }
}
