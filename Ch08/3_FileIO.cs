using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/20
 * 이름 : 정현기
 * 내용 : 파일 입출력 실습하기 
 * 
 */
namespace Ch08
{
    internal class _3_FileIO
    {
        static void Main(string[] args)
        {
            /////////////////////////
            ///파일입력(Read)
            /////////////////////////
            string path1 = "C:\\Users\\1302\\Desktop\\Sample1.txt";

            //Create Stream
            FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read);

            //텍스트 파일 전용 보조 스트림 연결
            StreamReader sr = new StreamReader(fs);

            //파일 읽기
            string line;
            while ((line =sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            //파일 닫기(자원 해제)
            sr.Close();
            fs.Close();




            /////////////////////////
            ///파일출력(Write)
            /////////////////////////
            string path2 = "C:\\Users\\1302\\Desktop\\Sample2.txt";
            
            //file stream 생성
            FileStream outfs = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write);
            //보조스트림 생성
            StreamWriter sw = new StreamWriter(outfs);

            //파일 쓰기
            sw.WriteLine("Welcome World");
            sw.WriteLine("Welcome Korea!!!!!!!!!!!");
            sw.WriteLine("Welcome Busan");

            //파일 닫기
            sw.Close();
            fs.Close();


            /////////////////////////
            ///파일읽기/쓰기
            /////////////////////////







        }

    }
}
