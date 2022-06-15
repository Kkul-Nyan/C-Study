using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch08
{
    internal class p401
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("int.TraParse()메서드");
            Console.WriteLine("숫자입력 : ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);

            if(result)
            {
                Console.WriteLine("입려한 숫자 : "+output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요");
            }
        }
    }
}
