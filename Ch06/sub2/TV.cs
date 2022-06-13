using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.sub2
{
    internal class TV :Internet, IComputer
    {
        public void PowerOn()
        {
            Console.WriteLine("켰습니다");
        }
        public void Booting()
        {
            Console.WriteLine("TV Booting...");        }

        public void Accessinternet()
        {
            base.Access();
        }
        public void PowerOff()
        {
            Console.WriteLine("종료합니다");
        }
    }
}
