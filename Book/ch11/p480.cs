using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch11
{
    internal class p480
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("강제로 던진 예외의 예외처리");
            try
            {
                throw new Exception();
            }
            catch(Exception exception)
            {
                Console.WriteLine("예외가 발생했습니다");
            }
        }
    }
}
