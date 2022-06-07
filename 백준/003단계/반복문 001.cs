using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._003단계
{
    internal class 반복문_001
    {
        static void Main(string[] args)
        {
            
               int B = int.Parse(Console.ReadLine());
            int Total = 0;
            
            for(int i = 1; i < 10; i++)
            { 
                Total = B * i;
                Console.WriteLine($"{B} * {i} = "+Total);

            }

        }

    }
}
