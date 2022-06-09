using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p357
    {
        class Program
        {
            public static int number = 10; //public int로 지정해도 되지만, statc에서 사용하기 위해  static 변수로 만듬 //그래봤자 새도잉됨. 변수이름이 겹쳐서 가까운 20을 쓰게됨

            static void Main1(string[] args)
            {
                Console.WriteLine("섀도잉");
                int number = 20;
                Console.WriteLine(number);
            }
        }
    }
}
