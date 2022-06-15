using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15
 * 이름 : 정현기
 * 내용 : stack -순서되로 상자에쌓고 다시 쌓은반대순서되로 꺼내는걸 상상하면된다.
 * 
 */

namespace Ch07
{
    internal class _1_stack
    {   
        static void Main1(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
            Console.WriteLine(stack.Pop());
            }   
        }



    }
}
