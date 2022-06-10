using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_003
    {
        static void Main1(string[] args)
        { //n n-1 n-2....n-i (n>i ++)
           int n = int.Parse(Console.ReadLine());
           int[] num = new int[n];
            //n =4
            //4,3,2,1
            //i= 0123
            for (int i =0 ; i < num.Length; i++)
            {
                num[i] = i+1;
            }

           int Total = 0;

           foreach (int item in num)
           {
                Total += item;
           }
           Console.WriteLine(Total);
        }
    }
}