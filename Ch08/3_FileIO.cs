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
 * 파일 입출력 (I/O)
 *  - 파일은 컴퓨터 저장매체에 저장되는 데이터 묶음
 *  - 프로그램은 데이터 처리(Process가공)와 더불어 처리결과를 저장하기에 파일 입출력을 수행
 *  - 
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
            FileStream fs = null;
            StreamReader sr = null;
            string path1 = "C:\\Users\\1302\\Desktop\\Sample1.txt";
            try
            {
                //Create Stream
                fs = new FileStream(path1, FileMode.Open, FileAccess.Read);

                //텍스트 파일 전용 보조 스트림 연결
                sr = new StreamReader(fs);

                //파일 읽기
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }

            finally
            {
                //파일 닫기(자원 해제)
                sr.Close();
                fs.Close();
            }



            /////////////////////////
            ///파일출력(Write)
            /////////////////////////
            string path2 = "C:\\Users\\1302\\Desktop\\Sample2.txt";
            FileStream outfs = null;
            StreamWriter sw = null;
            try
            {
                //file stream 생성
                outfs = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write);
                //보조스트림 생성
                sw = new StreamWriter(outfs);

                //파일 쓰기
                sw.WriteLine("Welcome World");
                sw.WriteLine("Welcome Korea!!!!!!!!!!!");
                sw.WriteLine("Welcome Busan");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //파일 닫기
                sw.Close();
                fs.Close();
            }

            /////////////////////////
            ///파일읽기/쓰기
            /////////////////////////

            string f1 = "C:\\Users\\1302\\Desktop\\Sample1.txt";
            string f3 = "C:\\Users\\1302\\Desktop\\Sample3.txt";
            try 
            {
                //using 선언하면 자동으로 자원반납 finally를 사용할 필요가없다.
                using var reader = new StreamReader(new FileStream(f1, FileMode.Open));
                using var writer = new StreamWriter(new FileStream(f3, FileMode.Create));

                string txt;

                while ((txt = reader.ReadLine()) != null)
                {
                    writer.WriteLine(txt);
                }
            
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }






        }

    }
}
