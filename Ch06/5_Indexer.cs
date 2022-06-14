using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/14
 * 이름 : 정현기
 * 내용 : 인덱서 실습하기 교재 p398
 * 
 * 인데서(Indexer)
 *  - 객체를 배열처럼 인덱스를 사용해서객체의 데이터를 참조 할 수 있게 해주는 속성
 *  - 인덱서를 메서드로 대체 가능
 */

namespace Ch06
{
    internal class _5_Indexer
    {

        class MyList
        {
            private int[] array;

            public MyList()
            {
                array = new int[3];
            }

            //인덱서 정의
            public int this[int i]
            {
                get { return array[i]; }
                set 
                {
                    if(i<array.Length)
                    {
                        array[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("더 이상 테이터를 저장 할 수 없습니다.");
                    }
                }
            }
            public int Length()
            {
                return array.Length;
            }
        }


        static void Main1(string[] args)
        {
            MyList mylist = new MyList();

            mylist[0]/*인덱서호출*/ = 100;
            mylist[1]/*인덱서호출*/ = 101;
            mylist[2]/*인덱서호출*/ = 102;
            mylist[3]/*인덱서호출*/ = 103; //<-더이상 ~ 출력X else로 가게됨

            for (int i= 0; i < mylist.Length() ; i++)
            {
                Console.WriteLine(mylist[i]);
            }

        }
    }
}
