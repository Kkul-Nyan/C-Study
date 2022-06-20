using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch10
{
    internal class p447
    {
        static void Main1(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\test\test.txt"))
            {
                Console.WriteLine("StreamReader 클래스로 파일 한줄씩 읽기");
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line); 
                }
            }

        }
    }
}
