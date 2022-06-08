using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p309
    {
      class Fibonicci
        {
            private static Dictionary<int, long> meno = new Dictionary<int, long>(); //계산한 피보나치 수를 저장하는 Dictionary 객체를 만듭니다
            public static long Get(int i)
            {
                //기본값
                if( i <0) { return 0; }
                if( i == 1) { return 1; }

                //이미 계산했던 값인지 확인합니다.
                if (meno.ContainsKey(i)) 
                { 
                    return meno[i]; 
                }
                //계산하지 않았다면 계산합니다.
                else
                {
                    long value = Get(i-2) + Get(i-1);
                    meno[i] = value;
                    return value;
                }
            }
        }

      class Program
      {
            static void Main(string[] args)
            {
                Console.WriteLine(Fibonicci.Get(40));
                Console.WriteLine(Fibonicci.Get(100));
            }
      }

    }
}
