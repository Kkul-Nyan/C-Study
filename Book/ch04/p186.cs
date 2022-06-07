using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p186
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Console.SetCursorPosition()메서드");
            Console.WriteLine("메서드 호출전");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("메서드 호출 후");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Console.Clear()메서드");

            Console.WriteLine("나이는?");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("나이 : "+A);
            Console.WriteLine("이름은 ?");
            string B = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("이름 : " + B);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("이름 : " + B);
            Console.WriteLine("나이 : "+A);
            Console.ReadLine();





        }

    }
}
