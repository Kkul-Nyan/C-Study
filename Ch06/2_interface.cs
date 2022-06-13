using Ch06.sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13
 * 이름 : 정현기
 * 내용 : 인터페이스 실습 교재 p425
 * 
 * 인터페이스(Interface)
 * - 클래스 간의 공통의 통일된 표준 규격을 통해 클래스 구조를 설계하는 문법
 * - 인터페이스를 활용해서 다중 상속을 구현한다.
 * - 인터페이스를 활용해서 객체간 결합도를 완화하는 효과를 얻는다.
 */

namespace Ch06
{
    internal class _2_interface
    {
        static void Main(string[] args)
        {
            //인터페이스로 공통 클래스 구조설계
            IRemoteControl lg = new LGRemocon();
            IRemoteControl samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.SoundUp();
            lg.ChDown();
            lg.PowerOff();

            samsung.PowerOn();
            samsung.SoundUp();
            samsung.ChDown();
            samsung.PowerOff();

            //인터패이스를 이용한 다중 상속
            //한 child 클래스가 2개의 부모를 갖지 못한다. 한쪽이 interface면 가능한다
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();
            
            //인터페이스를 활용한 결합도 완화
            Bulb bulb = new Bulb();
            ISocket cable = new Cable(bulb); //케이블안에서 생성자로 bulb를 만들었으니까 초기화 해줘야한다.

            ISocket.SwitchOn();
            ISocket.SwitchOff();

        }
    }
}
