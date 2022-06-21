using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 :2022/06/21
 * 이름 :정현기
 * 내용 : 데이터 베이스 프로그래밍 실습
 * 
 * MySQL 패키지 설치
 *  도구- NuGet 패키지 관리자 - 솔루션 NuGet패키지 관리... - mysql검색 - MySQL 데이터 설치
 *
 */
namespace Ch10
{
    internal class _1_DBConnection
    {
        static void Main1(string[] args)
        {
            //데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "testdb";

            //데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                //데이터 베이스 접속
                conn.Open();
                Console.WriteLine("접속성공...");
            }
            catch(Exception e)
            {
                Console.WriteLine("접속실패 : "+e.Message);
            }
            finally 
            {
                conn.Close();
                Console.WriteLine("접속종료...");
            }




        }
    }
}
