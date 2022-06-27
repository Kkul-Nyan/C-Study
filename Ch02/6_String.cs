using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/03
 * 이름 : 정현기 
 * 내용 : 문자열(string) 처리 실습 교재 p.112
 */


namespace Ch02
{
    internal class _6_String
    {
        static void Main1(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine("greeting : " +greeting);
            Console.WriteLine( );

            //문자열 길이
            Console.WriteLine("greeting 길이" +greeting.Length);
            Console.WriteLine();


            //문자열 추출
            Console.WriteLine("greeting[0] : " + greeting[0]);
            Console.WriteLine("greeting[3] : " + greeting[3]);
            Console.WriteLine("greeting[5] : " + greeting[5]);
            Console.WriteLine();

            //IndexOf 찾는것중 맨앞을 기준으로 숫자를 띄워줌
            Console.WriteLine("IndexOf 'G' : "+greeting.IndexOf('G'));
            Console.WriteLine("IndexOf \"G\" : "+greeting.IndexOf("G"));
            Console.WriteLine("IndexOf 'o' : "+greeting.IndexOf('o'));
            Console.WriteLine("IndexOf \"Mor\" : " + greeting.IndexOf("Mor"));
            Console.WriteLine("IndexOf \"ing\" : " + greeting.IndexOf("ing"));
            Console.WriteLine();


            //LastIndexOf 찾는것중 맨뒤를 기준으로 찾아서 띄워줌. 단어기준 뒤에서 찾아서 맨앞 알파뱃의 위치를 구해준다
            Console.WriteLine("LastIndexOf 'G' : "+greeting.LastIndexOf('G')); 
            Console.WriteLine("LastIndexOf 'o' : "+greeting.LastIndexOf('o')); 
            Console.WriteLine("LastIndexOf \"Mor\" : " + greeting.LastIndexOf("Mor")); 
            Console.WriteLine("LastIndexOf \"ing\" : " + greeting.LastIndexOf("ing")+"\n");

            
            //Substring 문자열 짜르는것. 앞숫자가 시작되는 인덱스 숫자, 뒤에 숫자는 길이 0,4는 0번째부터 4개
            //뒤에 길이를 지정해주는 숫자가 없이 시작 인덱스만 있으면 거기부터 그냥 끝까지 달린다.
            Console.WriteLine("Substing(0, 4) : {0}",greeting.Substring(0, 5));
            Console.WriteLine("Substing(5, 7) : {0}",greeting.Substring(5, 7));
            Console.WriteLine("Substing(5) : {0}",greeting.Substring(5));
            Console.WriteLine();


            //Replace 
            string replaced = greeting.Replace("Morning", "Afternoon");
            Console.WriteLine("relaced : "+replaced);
            Console.WriteLine();

            //기본형 데이터를 문자열로 변환
            int var1 = 1;
            double var2 = 2.12;
            bool var3 = true;

            string str1 = var1.ToString();
            string str2 = var2.ToString();
            string str3 = var3.ToString();

            Console.WriteLine("str1 : "+str1);
            Console.WriteLine("str2 : "+str2);
            Console.WriteLine("str3 : "+str3);
            Console.WriteLine();



            //문자열 데이터를 기본형으로 변환
            string s1 = "3";
            string s2 = "3.14";
            string s3 = "false";

            int r1 = int.Parse(s1);
            double r2 = double.Parse(s2);
            bool r3 = bool.Parse(s3);

            Console.WriteLine($"r1 : {r1}");
            Console.WriteLine($"r2 : {r2}");
            Console.WriteLine($"r3 : {r3}");
            Console.WriteLine();
        }
    }
}
