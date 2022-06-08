using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._002단계
{
    internal class 조건문_004
    {
        static void Main1(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int x = int.Parse(str1);
            int y = int.Parse(str2);

            if(x>0 && y>0)
            { Console.WriteLine("1"); }
            else if(x<0 && y>0)
            { Console.WriteLine("2"); }
            else if(x<0 && y<0)
            { Console.WriteLine("3"); } 
            else
            { Console.WriteLine("4"); }

        }
    }
}
