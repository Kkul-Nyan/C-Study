using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/03
 * 이름 : 정현기
 * 내영 : 데이터 형식 변환 실습 교재 p106
 */

namespace Ch02
{
    internal class _5_Conversion
    {
       static void Main3(string[] args)
        {
            //작은 변수에서 큰변수
            byte num1 = 255;
            short num2 = num1;
            int num3 = num2; 
            
            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);  //문제 될거없이 잘된다
            

            //큰변수에서 작은변수
            int   var1 = 256;
            short var2 =(short) var1; //넘쳐서 문제생긴다. 강제로 변환 시킬거면 (short)로 하면 되긴된다.
            byte var3 = (byte)  var2;

            Console.WriteLine($"var1 : {var1}");
            Console.WriteLine($"var2 : {var2}");
            Console.WriteLine($"var3 : {var3}");

            //정수에서 실수  int는 4byte고 double은 8byte 
            int a = 1;
            int b = 2;
            int c = 3;
            
            double d1 = a;
            double d2 = b;
            double d3 = c;

            Console.WriteLine("d1 : "+d1);
            Console.WriteLine("d2 : "+d2);
            Console.WriteLine("d3 : "+d3);

            //실수에서 정수 강제캐스팅(변환)이 필요함
            double n1 = 1.2;
            double n2 = 2.15;
            double n3 = 11.123;

            int rs1 = (int)n1;
            int rs2 = (int)n2;
            int rs3 = (int)n3;
        }
    }
}
