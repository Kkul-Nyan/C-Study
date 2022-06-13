using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch09
{
    internal class p447
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\test\test.txt"))
            {
                Console.WriteLine("StreamReader 클래스로 파일 한 줄씩 읽기");
                string line;
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);

                //while 내부에 넣어야함.
                //string line1 = reader.ReadLine() != null; 
                //while (line1)
                //Console.WriteLine(line1);
            }
        }
    }
}