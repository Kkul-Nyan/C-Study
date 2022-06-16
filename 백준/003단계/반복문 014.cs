using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_014
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = 0;

            int num1 = A / 10;
            int num2 = A % 10;
          
            //26  = 2+6=8
            //   -> 6+8=14
            //   -> 8+4=12
            //   -> 4+2= 6 ->2+6
            if(A>0)
            {
                int i = 0;
                while (true)
                {
                    int num3 = num1 + num2;
                    List<int>num = new List<int>();
                    num[i + 3] = num[i] + num[i + 1];
                    i ++;

                    if ( num[i + 1] == A / 10 && num[i + 3] == A % 10 )
                    { break; }
                }
                Console.WriteLine(i);
            }
           




        }
    }
}
