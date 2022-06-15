using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/15
 * 이름 : 정현기
 * 내용 : 컬렉션 큐 실습 - 넣은순서되로 꺼낸다
 * 
 */

namespace Ch07
{
    internal class _2_queue
    {
        static void Main1(string[] args)
        {
            Queue<string>que = new Queue<string>();

            que.Enqueue("1");
            que.Enqueue("2");
            que.Enqueue("3");
            que.Enqueue("4");
            que.Enqueue("5");

            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
