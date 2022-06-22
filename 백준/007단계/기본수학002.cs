using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._007단계
{

    internal class 기본수학002
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long step1 = input - 1;
            int k = 1;
            while(step1 > 0 )
            {
                k++;
                step1 -= 6 * (k-1);
                
            }
            if (input < 2)
            { k = 1; }
            Console.WriteLine(k);
        }
    }
}
//12  11 6 
// 30  29 23  11 
//  59 58 

// 1   2        3          4         5
// 1  2~7      8~ 19      20~37    38~61 
// 1   6        12         18        24
// 1   7        19         37        61
//     1        3           6        10