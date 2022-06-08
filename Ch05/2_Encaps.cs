using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022 /06/08
 * 이름 : 정현기
 * 내용 : 캡슐화 실습하기 교재 p203
 *  
 */

namespace Ch05
{
    internal class _2_Encaps
    {
        static void Main(string[] args)
        {
           Account kb = new Account("국민은행", "123-12-1234", "김유신", 1000);
     


            kb.Deposit(4000);
            kb.Withdraw(3000);
          
            //캡술화를 하지 않아, 취약점 발생
           // kb.balance--;
            // kb.balance -= 10;
            
            
            
            kb.Show();

            Car sonata = new Car("소나타", "흰색", 0);
            Car BMW = new Car("BMW", "검정색", 0);
            Car Benz = new Car("벤츠", "검정색", 0);

            //setter 실행
            sonata.Name = "EF소나타";
            sonata.Speed = -100;

            //getter 실행
            Console.WriteLine("sonata 객체 name : " + sonata.Name);


            sonata.SpeedUp(60);
            sonata.Show();

            BMW.SpeedUp(50);
            BMW.Show();

            Benz.SpeedUp(10);
            Benz.Show();

        }   
    }
}
