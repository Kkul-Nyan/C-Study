using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
    class NotFoundException : Exception
    {
        public NotFoundException() : base("해당하는 숫자를 찾을수 없습니다.") { }
    }

    internal class _5_02
    {
        static void Main1(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            Console.Write("찾을 숫자 입력 : ");

            try
            {
                int find = Convert.ToInt32(Console.ReadLine());
                // int.parse하고 convert.toint32 차이는 뭔가?
                searchArray(find, arr);
                Console.WriteLine("해당하는 숫자 찾음!!!");

            }
            catch(NotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("프로그램 정상 종료...");
        }
        public static void searchArray(int find, int[] arr)
        {
            foreach(int i in arr)
            {
                if(i== find)
                { return; } //return은 메서드를 종료시킨다 즉 , throw는 작동안하고 메서드에서 빠져나간다.
            }
            throw new NotFoundException();
        }
    }
}
