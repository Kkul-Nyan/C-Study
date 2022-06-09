using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Sedan : Car //상속이므로 생성자에 상속표시를 해줘야한다.
    {
        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("차량명 : "+name);
           // Console.WriteLine("차량명"+name); 안되는 이유는 부모클래스가 캡슐화되어있음. 부모클래스에서 private를 protected로 바꿔줘야한다.
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 : "+speed);
            Console.WriteLine("차량배기량 : "+cc);
            Console.WriteLine("================");
        }




    }
}
