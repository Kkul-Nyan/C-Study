using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch10
{
    class Parent { }
    class Child : Parent, IDisposable, IComparable
    {
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose() //불필요한 메모리 누출 방지, 이미사용했는데 커져있으면 꺼준다
        {
            throw new NotImplementedException();
        }
    }
    internal class p440
    {
        static void Main1(string[] args)
        {
            Console.WriteLine( "인터페이스를 다중상속");
            Child child = new Child();
            Parent childAsparent = new Child();
            IDisposable childAsDisposable = new Child();
            IComparable childAsComparable = new Child();
        }
    }
}
