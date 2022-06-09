using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch07
{
    internal class p358
    {
        class Parent
        {
            public int variable = 273;
        }

        class Child : Parent
        {
            public string variable = "shadowing";
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("변수 하이딩");
            Child child = new Child();
            Console.WriteLine(child.variable);
        }
    }
}
