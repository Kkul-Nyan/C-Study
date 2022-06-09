using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 정현기
 * 내용 : 오법라이드 실습하기 교재 p361
 */

namespace Ch05
{
    class AAA 
    {
        public void Method1()
        {
            Console.WriteLine("AAA::Method1 ...");
        }
        public void Method2()
        {
            Console.WriteLine("AAA::Method2 ...");
        } 
        public void Method3()
        {
            Console.WriteLine("AAA::Method3 ...");
        }
    }
    class BBB : AAA 
    {
        public void Method1()
        {
            Console.WriteLine("BBB::Method1 ...");
        }
        public void Method2()
        {
            Console.WriteLine("BBB::Method2 ...");
        }
        public void Method3()
        {
            Console.WriteLine("BBB::Method3 ...");
        }
    }
    class CCC : BBB 
    {
        public void Method1()
        {
            Console.WriteLine("CCC::Method1 ...");
        }
        public void Method2()
        {
            Console.WriteLine("CCC::Method2 ...");
        }
        public void Method3()
        {
            Console.WriteLine("CCC::Method3 ...");
        }
    }

    internal class _5_Override
    {
        static void Main(string[] args)
        {



        }
    }
}
