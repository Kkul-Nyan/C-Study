using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p285
    {
        class Program
        {
            class Hidden
            {
                private Hidden() { }
            }

            static void Main(string[] args)
            {
                // Hidden hidden = new Hidden(); 같은 내부클라스도 상위클라스에서 땡기는것도 아니므로 접근할수가없다.
            }
        }
    }
}
