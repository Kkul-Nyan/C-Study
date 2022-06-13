using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch09
{
    class Parent { }

    class Child : Parent, IDisposable, IComparable
    {
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    internal class p440
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("다중 상속");
        }
    }

}
