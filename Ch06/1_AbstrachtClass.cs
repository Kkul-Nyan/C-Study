using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13
 * 이름 : 정현기
 * 내용 : 추상클래스 실습하기 교재 p230
 * - 공통의 기능은 하나의 메서드로 구형하고 개별적인 기능은 상속받아 override 메서드로 구현시키는 추상메서드를 갖는 클래스
 */

namespace Ch06
{
 

    internal class _1_AbstrachtClass
    {
        static void Main(string[] args)
        {
            Car truck09 = new Truck ("포터09","검정색",0,1400);
            Sedan sedan = new Sedan("그렌저", "검정색", 0, 2000);
            Truck truck = new Truck("포터", "파란색", 0, 1000);

            sedan.SpeedUp(100);
            sedan.SpeedDown(20);
            sedan.Show();

            truck.SpeedUp(50);
            truck.SpeedDown(30);
            truck.Show();
            
            
            truck09.SpeedUp(50);
            truck09.SpeedDown(30);
            truck09.Show();
        }


    }
}
