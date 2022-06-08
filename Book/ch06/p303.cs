using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch06
{
    internal class p303
    {
        class Program
        {
            class Test
            {
                public int value = 10;
            }

            static void Change(Test input)
            {
                input.value = 20;
            }
            static void Main1(string[] args)
            {
                Console.WriteLine("참조복사 예");
                //결국 svm은 현실세계 다른 class구역들은 가상현실. 현실세계에서 눈이안좋음 VR기계로하는 가상게임에서 시야가 당연히 잘보여지지않음, 가상게임에서 시야가 흐릿해짐->현실세계에 아무 영향을 끼칠수없음 내눈은 잘보임
                //현실 세계에서 가상세계에 불편을위해 먼가 개념이나 사실이 변하지 않음. 그러나 가상사계(class)는 현실(svm)에 맞춰서 값을 변화할수있음
                Test test = new Test();
                test.value = 30;
                Change(test);

                Console.WriteLine(test.value);
            
            }
        }
    }
}
