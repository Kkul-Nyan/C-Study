using Ch07.sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15
 * 이름 : 정현기
 * 내용 : 컬렉션 ArrayList 실습
 * 
 * ArrayList
 *  - 배열과 유사한 동적 선형 자료구조
 *  - ArrayList를 일반화 시킨 자료구조 ArrayList보다 더 나은 성능
 *  
 */


namespace Ch07
{
    internal class _3_Arraylist
    {
        static void Main1(string[] args)
        {
            //ArrayList생성

            ArrayList list1 = new ArrayList();

            //데이터입력
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            //데이터출력
            foreach(int i in list1)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //데이터삽입
            list1.Insert(1, 6);
            //데이터 출력
            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            
            //데이터삭제
            list1.Remove(6); //6이란 변수를 찾아서 제거
            list1.RemoveAt(0); //인덱스0번 자리 삭제
            //데이터 출력
            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        
            //다양한 형식의 데이터를 갖는 ArrayList
            ArrayList list2 = new ArrayList();
            list2.Add(100);
            list2.Add(0.123);
            list2.Add(true);
            list2.Add('A');
            list2.Add("Apple");
            Console.WriteLine();
            Console.WriteLine();

            for (int u = 0; u < list2.Count; u++)
            { 
                Console.WriteLine(list2[u]); 
            }
            
            //////////////////////////////////////
            //list 교재 p.211
            //////////////////////////////////////
            
            List<int> list3 = new List<int>();

            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.Add(4);
            list3.Add(5);
            list3.Add(6);
            Console.WriteLine();
            Console.WriteLine();

            foreach(int R in list3)
            {
                Console.Write(R+" ");
            }
            Console.WriteLine();

            List<string> list4 = new List<string>();
            list4.Add("김유신");
            list4.Add("김춘추");
            list4.Add("장보고");
            list4.Add("강감찬");
            list4.Add("이순신");
         

            foreach (var Y in list4)
            {
                Console.Write(Y +" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            List<Apple> list5 = new List<Apple>(); //객체 apple을 담는다

            list5.Add(new Apple("한국", 3000));
            list5.Add(new Apple("미국", 2000));
            list5.Add(new Apple("일본", 1000));
            
            Apple a1 = list5[0];
            a1.show();
            list5[1].show();
            list5[2].show();
            Console.WriteLine();
            Console.WriteLine();
            
            foreach(Apple A in list5)
            {
                Console.Write(A.show); //비작동 직접확인할것
            }

        }
    }
}
