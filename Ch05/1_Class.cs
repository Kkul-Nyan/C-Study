using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022 /06/08
 * 이름 : 정현기
 * 내용 : 클래스와 객체 실습하기 교재 p203
 *  
 *  클래스와 객체
 *   - 클래스는 객체를 생성하는 구조쳉며, 필드와 메서드로 구성된다.
 *   - 객체는 클래스의 실제 인스턴스이며, new연산자로 생성한다.
 */

namespace Ch05
{
    internal class _1_Class
    {
        static void Main(string[] args)
        {
            //객체 생성. Car로만해서 클래스를가져오지 못해서 Ctrl + .(참조연산자)로 출처를 가져온다.
            Car sonata = new Car();

            //객체 초기화(막 만든 객체는 아무 내용이없음 / 참조연산자 .으로 내용을 넣어준다.)
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            //객체기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            //객체 생성(bmw, 검정색)
           Car bmw = new Car();
            bmw.name = "비엠더블유";
            bmw.color = "검정색";
            bmw.speed = 0;

            //Account 객체생성
            Account kb = new Account();
            //초기화
            kb.bank = "국민은행";
            kb.id = "123-12-1234";
            kb.name = "김유신";
            kb.balance = 10000;

            kb.Deposit(25000);
            kb.Withdraw(5000);
            kb.Show();

            //nh 객체생성
            Account nh = new Account();
            nh.bank = "농협은행";
            nh.id = "321-12-4321";
            nh.name = "김춘추";
            nh.balance = 30000;

            nh.Deposit(70000);
            nh.Withdraw(20000);
            nh.Show();




                
          


        }
    }
}
