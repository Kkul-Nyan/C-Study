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
 * 내용 : 컬렉션 Hashtable/Dictionary 실습
 * 
 */
namespace Ch07
{
    internal class _4_Hashtable
    {
        static void Main1(string[] args)
        {
            //테이블 생성
            Hashtable table = new Hashtable();
            //키벨루 쌍으로 데이터 저장 (K-v)
            table['A'] = "Apple";
            table['B'] = "Banana";
            table['C'] = "Cherry";

            //데이터 출력 key를 넣으면 value가 출력됨
            Console.WriteLine( "table['A'] : "+ table['A']);
            Console.WriteLine( "table['B'] : "+ table['B']);
            Console.WriteLine( "table['C'] : "+ table['C']);

            //반복문 데이터 출력
            foreach(char c in table.Keys)
            {
                Console.WriteLine(table[c]);
            }
            
            ////////////////////////////////////////////
            //Dictionary
            ////////////////////////////////////////////
            
            Dictionary<char, string> dic = new Dictionary<char, string>(); //char는 key, string는 value값이다
            dic['A'] = "Apple1";
            dic.Add('B', "Banana1");
            dic.Add('C', "Cherry1");

            //데이터 출력
            Console.WriteLine();
            Console.WriteLine();
            foreach(char f in dic.Keys)
            {
                Console.WriteLine(dic[f]);
            }
            Console.WriteLine("Dic['A'] : " + dic['A']);
            
            foreach (string fruit in dic.Values)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Dictionary 생성2
            Dictionary<int, string> people = new Dictionary<int, string>();



            //Dictionary 입력2
            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            //Dictionary 데이터 출력2

            foreach(int i in people.Keys)
            {
                Console.Write("너의 이름은 ?        ");
                Console.WriteLine(people[i]);
            }
            Console.WriteLine();
            Console.WriteLine("이름은 : " + people[101]);
            Console.WriteLine();

            ////////////////////////////////////////////
            //Dictionary/List 응용예제
            ////////////////////////////////////////////

            Dictionary<int, Apple> d1 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d2 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d3 = new Dictionary<int, Apple>();

            d1.Add(101, new Apple("한국", 3000));
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("일본", 1000));

            d2.Add(201, new Apple("중국", 3000));
            d2.Add(202, new Apple("대만", 1500));
            d2.Add(203, new Apple("홍콩", 2400));
            
            
            d3.Add(301, new Apple("호주", 3000));
            d3.Add(302, new Apple("영국", 2000));
            d3.Add(303, new Apple("인도", 800));

            List<Dictionary<int,Apple>> apples = new List<Dictionary<int, Apple>>();
            apples.Add(d1);
            apples.Add(d2);
            apples.Add(d3);
            //한국 사과
            Dictionary<int, Apple> d = apples[0];
            Apple a = d[101];
            a.show();



            //미국 사과
            apples[0][102].show();

            //대만 사과
            apples[2][202].show();

            //인도 사과
            apples[3][303].show();




        }
    }
}
