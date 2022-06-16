using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    
    class Vehicle
    {
        private string name;
        private int price;

        public Vehicle(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("====================");
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("가격 : " + price);
            Console.WriteLine("--------------------");
        }
    }

    class CarFactory   //싱글톤
    {
        private static CarFactory instance = new CarFactory();
        private CarFactory() { } //생성자호출못하게 만들어진 생성자

        public static CarFactory Instance
        {
            get { return instance; }
        }

        public Vehicle MakeCar(string name, int price) //리턴값이 들어가야함  ->return이므로 void안됨
        {
            return new Vehicle(name, price); // == vehicle v = new vehicle 이란 의미
        }
    }

    internal class _3_05
    {
        static void Main1(string[] args)
        {
            CarFactory factory = CarFactory.Instance;

            Vehicle avante = factory.MakeCar("아반떼", 2500);
            Vehicle sonata = factory.MakeCar("소나타", 3000);

            avante.Show();
            sonata.Show();

        }
    }
}
