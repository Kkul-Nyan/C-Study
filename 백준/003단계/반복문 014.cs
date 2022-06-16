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
            if(A>9)
            {
                int i = 1;
                while (true)
                {
                    int num3 = (num1 + num2) % 10;
                    if (num2 == A / 10 && num3 == A % 10)
                    { break; }
                    num1 = num2;
                    num2 = num3;
                    
                    i ++;
                    
                }
                Console.WriteLine(i);
            }
            else
            {
                num1 = 0;
                int j = 1;
                while (true)
                {
                    int num3 = (num1 + num2) % 10;

                    if (num2 == A / 10 && num3 == A % 10)
                    { break; }

                    num1 = num2;
                    num2 = num3;
                    j++;

                }
                Console.WriteLine(j);
            }




        }
    }
}
