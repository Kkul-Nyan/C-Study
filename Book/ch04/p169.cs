using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p169
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("외부요인으로 조건변경 언제 while반복문을 사용하고, 언제 for반복문을 사용해야하나요?");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("시간을 사용한 반복문 이탈");
            Console.WriteLine();
            
            long start = DateTime.Now.Ticks;
            long count = 0;

            while(start + (10000000)>DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count+"만큼 반복했습니다.");
        
            for(long A= DateTime.Now.Ticks; A + (10000000) >DateTime.Now.Ticks; count ++ )
            {
          
            }
            Console.WriteLine(count+"만큼 반복했습니다.");
        }

    }
}
