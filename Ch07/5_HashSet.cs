using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/15
 * 이름 : 정현기
 * 내용 : 컬렉션 HashSet실습
 */

namespace Ch07
{
    internal class _5_HashSet
    {
        static void Main(string[] args)
        {   //중복 허용안하고 날려버린다.
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(2);
            set.Add(3);

            //데이터출력
            Console.WriteLine("집합 원소 갯수 : "+set.Count);
            foreach(int n in set)
            {
                Console.WriteLine(n+" ");
            }
            Console.WriteLine();

            //집합연산
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 5, 6, 7 };

            //교집합
            /*IEnumerable대신 var로도 가능*/
            IEnumerable<int>result1 = set1.Intersect(set2);
            IEnumerable<int>result2 = set1.Union(set2); //합집합
            IEnumerable<int>result3 = set1.Except(set2); //차집합
            
            foreach(int n in result1)
            { 
                Console.Write(n+" "); 
            }
            Console.WriteLine();
            foreach(int n in result2)
            { 
                Console.Write(n+" "); 
            }
            Console.WriteLine();
            foreach(int n in result3)
            { 
                Console.Write(n+" "); 
            }
            Console.WriteLine();


        }
    }
}
