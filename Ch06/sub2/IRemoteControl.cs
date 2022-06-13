using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//인터페이스는 이름앞에 대문에 I
namespace Ch06.sub2
{
    internal interface IRemoteControl
    {
        //인터페이스는 추상메서드만 갖는다.
        public void PowerOn();
        public void PowerOff();

        public void ChUp(); //abstract 생략
        public void ChDown();

        public void SoundUp();
        public void SoundDown();


    }
}
