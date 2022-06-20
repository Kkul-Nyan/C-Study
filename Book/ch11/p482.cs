using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch11
{
    internal class p482
    {
        class CustomException : Exception
        {
            public CustomException(string message) : base(message)
            { 
            
            }
        }


        static void Main1(string[] args)
        {
            Console.WriteLine("예외 클래스 만들기");
            try
            {
                throw new CustomException("사용자 정의 예외");
            }
            catch(CustomException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
