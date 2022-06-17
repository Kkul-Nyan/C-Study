using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열006
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            char[] ch = str[0].ToCharArray();
            int final = 0;
            //t로 총 반복문을 몇번할건지 확정
            for (int i = 0; i < t; i++)
            {
                int num = 0;
                int Total = 0;
                int count = 0;
                for (int j = 0; j < ch.Length; j++)
                {
                    Console.Write(ch[0] + " "); Console.WriteLine(ch[1]);
                    while (ch[count] ==  )
                    {
                        count ++;
                    }
                    for(int q=0; q < ch.Length; q++)
                    { 
                        int[] nums = new int[count];
                    
                        Console.WriteLine("count : "+count);
                    
                        for (int k = 0; k < count; k++)
                        {
                            num += 1;
                            nums[k] = num;
                        }
                        int total = 0;

                         foreach(int a in nums)
                        { Console.Write("nums 그룹 : "+a); }
                    
                        for (int u = 0; u < count; u++)
                        {
                        total += nums[u];
                        Console.WriteLine("total"+total);
                        }
                     Total += total;
                     Console.WriteLine("Total" + Total);
                    }

                }
                final += Total;
                Console.WriteLine("final"+final);
            }

            
        
        
        
        
        }
    }
}
