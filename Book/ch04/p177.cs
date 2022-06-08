using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p177
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("break 키워드");

            while(true)
            {
                Console.WriteLine("짝수를 입력하면 종료 : ");
                int input= int.Parse(Console.ReadLine());
                if (input%2 ==0)
                {
                    break;
                }
            }

            Console.WriteLine("아이디 입력해주세요");
            while(true)
            {
                Console.WriteLine("아이디는 8글자 이하로 다시 설정해주세요");

                string name = Console.ReadLine().ToString();
                
                if(name.Length < 8)
                {
                    break;
                }
            }
           
            
        }
    }
}
