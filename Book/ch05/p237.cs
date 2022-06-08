using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p237
    {
        class Student
        {
            public string name;
            public int grade;
        }

        static void Main1(string[] args)
        {

            Console.WriteLine("역 for 반복문을 사용한 제거");
            
            Console.WriteLine();
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "연하진", grade = 2 });
            list.Add(new Student() { name = "윤아린", grade = 3 });
            list.Add(new Student() { name = "윤명월", grade = 4 });
            list.Add(new Student() { name = "구지연", grade = 1 });
            list.Add(new Student() { name = "김연화", grade = 2 });

            for(int i =list.Count-1;i>=0;i--)
            {
                if(list[i].grade > 1)
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
