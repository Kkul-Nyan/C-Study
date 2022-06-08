using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p235
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
            Console.WriteLine("for문 역시 작동은 하나 제대로 지워지지 않고, 윤아린 : 3이 남아있다. 이는 인덱스가 삭제되면서 순서가 밀렸기 때문이다.");
            Console.WriteLine();
            List<StudentC> list = new List<StudentC>();
            list.Add(new StudentC() { name = "윤인성", grade = 1 });
            list.Add(new StudentC() { name = "연하진", grade = 2 });
            list.Add(new StudentC() { name = "윤아린", grade = 3 });
            list.Add(new StudentC() { name = "윤명월", grade = 4 });
            list.Add(new StudentC() { name = "구지연", grade = 1 });
            list.Add(new StudentC() { name = "김연화", grade = 2 });

            foreach (var item in list)
            {
                if (item.grade > 1)
                {
                    list.Remove(item);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}
