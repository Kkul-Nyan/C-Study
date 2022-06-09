using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub5
{
    internal class Animal
    {
        public void Move()
        {
            Console.WriteLine("Animal Move...");
        }
        public virtual void Move1()
        {
            Console.WriteLine("Animal Move...");
        }
    }
}
