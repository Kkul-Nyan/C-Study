using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p211
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("배열생성");
            int[] intArray = new int[10];
            long[] longArray = new long[10];   
            string[] stringArray = new string[10];
            //3개다 10개의 배열을 갖는다 넘어가면 오류가 생김
            Console.WriteLine();
            Console.WriteLine("List 클래스의 인스턴트 생성");
            {
                List<int> list = new List<int>();
            }
            //List 클래스를 이용하여 가변적인 배열을 만들수 있다
        }
    }
}
