using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._005단계
{
    internal class 함수_002
    {

        static void Main1(string[] args)
        {
            int i = 1;
            List<int> self = new List<int>();
            while (i < 10000)
            {
                bool k = true;
                for (int j = 1; j < 10000; j++)
                {
                    int one = j % 10;
                    int ten = (j / 10) % 10;
                    int hun = (j / 100) % 10;
                    int thu = (j / 1000) % 10;
                    int drnum = j + one + ten + hun + thu;
                    
                    if (i == drnum)
                    {
                        k = false;
                    }
                }
                if(k == true)
                {
                    self.Add(i);
                }
                i++;
            }
            foreach(var y in self)
            { Console.WriteLine(y); }

        }
    }
}
