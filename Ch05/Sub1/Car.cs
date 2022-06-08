using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car
    {
        //속성(필드-변수)
        public string name;
        public string color;
        public int speed;

        //기능(메서드)
        public void SpeedUp(int speed)
        {
            this.speed += speed; //this.는 class에 변수 라는것을 표현
        }
        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }
        public void Show()
        {
            Console.WriteLine("============");
            Console.WriteLine("차량명 : "+this.name);
            Console.WriteLine("차량색 : "+ this.color);
            Console.WriteLine("차량속도 : "+ this.speed);
        }
    }
}
