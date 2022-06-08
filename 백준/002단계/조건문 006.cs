using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._002단계
{
    internal class 조건문_006
    {
        static void Main1(string[] args)
        {
            string [] str = Console.ReadLine().Split();
            string C = Console.ReadLine();

            int H = int.Parse(str[0]);
            int M = int.Parse(str[1]);
            int CT = int.Parse(C);

            int H1 = H * 60;
            int TT = H1 + M;
            int TC = TT + CT;
            int FH = TC / 60;
            int FM = TC % 60;

            if (TC < 1440)
            { Console.WriteLine(FH + " " + FM); }
            else
            { 
                int OverTime = TC - 1440;
                int OH = OverTime / 60;
                int OM = OverTime % 60;
                Console.WriteLine(OH+" "+OM);
            
            }

        }
    }
}
