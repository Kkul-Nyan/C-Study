using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {
        //속성(필드-변수)
        private string name;
        private string color;
        private int speed;

        //Getter, Setter -->C#에서는 프로퍼티
        public string Name { get {return name;} set { name = value; }}
        public string Color { get {return color;} set {color = value;} }
        public int Speed 
        { 
            get 
            {
                return speed;
            }
            set 
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else if (value > 300)
                {
                    value = 300;
                }
                else
                {
                    speed = value;
                }
            }
        }


        //생성자
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        //소멸자  ~생산자() 표시
        ~Car()
        {
            Console.WriteLine("{0}Car 소멸자 실행...", name);
        }

    

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
