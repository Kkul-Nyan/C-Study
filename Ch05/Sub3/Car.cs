﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Car
    {
        //속성(필드-변수) //private가 아닌 protected는 상속을 위해 바꿔둔것.
        protected string name;
        protected string color;
        protected int speed;
        protected static int count;

        //생성자
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            count++;
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
            global::System.Console.WriteLine("전체 차량수 : "+count);
        }
    }
}
