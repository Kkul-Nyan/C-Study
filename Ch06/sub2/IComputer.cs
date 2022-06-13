using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.sub2
{
    internal interface IComputer
    {
        public void Booting() { Console.WriteLine("부팅중입니다"); }
           
        public void AccessInternet(){}
    }
}
