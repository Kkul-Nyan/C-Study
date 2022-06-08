using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p236
    {
        class StudentC
        {
            public string name;
            public int grade;
        }

        static void Main1(string[] args)
        {

            Console.WriteLine("foreach 반복문으로 요소제거");
            Console.WriteLine("처리되지 않은 예외로 에러가 발생한다. foreach반복문을 사용해서는 요소 제거를 할수 없다");
            Console.WriteLine("for문에서 삭제시 인덱스 밀림으로 지워져야할 자료가 살아있는 문제가 있었지만, 역for문에서는 동일문제없이 완전히 제거됨을 확인할수있다.");
            Console.WriteLine();
            List<StudentC> list = new List<StudentC>();
            list.Add(new StudentC() { name = "윤인성", grade = 1 });
            list.Add(new StudentC() { name = "연하진", grade = 2 });
            list.Add(new StudentC() { name = "윤아린", grade = 3 });
            list.Add(new StudentC() { name = "윤명월", grade = 4 });
            list.Add(new StudentC() { name = "구지연", grade = 1 });
            list.Add(new StudentC() { name = "김연화", grade = 2 });

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].grade>1)
                {
                    list.RemoveAt(i);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}
