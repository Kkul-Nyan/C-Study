using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch05
{
    internal class p233
    {
        class StudentB
        {
            public string name;
            public int grade;
        }

        static void Main1(string[] args)
        {

            Console.WriteLine("모델클래스와 List 클래스");
            Console.WriteLine();
            List<StudentB> list1 = new List<StudentB>();
            list1.Add(new StudentB() { name = "윤인성", grade = 1 });
            list1.Add(new StudentB() { name = "연하진", grade = 2 });
            list1.Add(new StudentB() { name = "윤아린", grade = 3 });
            list1.Add(new StudentB() { name = "윤명월", grade = 4 });
            list1.Add(new StudentB() { name = "구지연", grade = 1 });
            list1.Add(new StudentB() { name = "김연화", grade = 2 });

            foreach(var item1 in list1)
            {
                Console.WriteLine(item1.name + " : "+ item1.grade);
            }
        }
    }
}
