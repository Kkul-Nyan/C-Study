using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class p85
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("문자변수생성");
            
            char a = 'a';
            Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sizeof연산자와 char자료형의 크기");
            Console.WriteLine("int: "+sizeof(int));
            Console.WriteLine("long: "+sizeof(long));
            Console.WriteLine("float: "+sizeof(float));
            Console.WriteLine("double: "+sizeof(double));
            Console.WriteLine("char: "+sizeof(char));
        }
    }
}
