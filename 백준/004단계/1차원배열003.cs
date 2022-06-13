using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열003
    {


        static void Main(string[] args)
        {
            //A*B*C=D
            //D값에 0~9까지 쓰인 숫자 카운드 D= 1000 -> 3 1 , D=1135423 ->0 2 1 2 1 1

            string numA = Console.ReadLine();
            string numB = Console.ReadLine();
            string numC = Console.ReadLine();
            int A = int.Parse(numA);
            int B = int.Parse(numB);
            int C = int.Parse(numC);
            //D의 숫자를 나누어서 배열로 만들기
            
            int D = A * B * C;
            string total = D.ToString();
            int[] Total = new int[total.Length];
            
            for( int i = 0; i < total.Length; i++)
            {
                Total[i] = D % 10;
                 D /= 10;             
            }

            foreach(int item in Total)
            {
                Console.Write(item);

            }
            Console.WriteLine();
            Console.WriteLine();

            //12345
            int num0 = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;    
            int num4 = 0;    
            int num5 = 0;    
            int num6 = 0;    
            int num7 = 0;    
            int num8 = 0;    
            int num9 = 0;    
                

            for (int k =0; k< Total.Length; k++)
            {
                switch(Total[k])
                {
                    case 0:
                        num0++;
                        break;
                    case 1:
                        num1++;
                        break;
                    case 2:
                        num2++;
                        break;
                    case 3:
                        num3++;
                        break;
                    case 4:
                        num4++;
                        break;
                    case 5:
                        num5++;
                        break;
                    case 6:
                        num6++;
                        break;
                    case 7:
                        num7++;
                        break;
                    case 8:
                        num8++;
                        break;
                    case 9:
                        num9++;
                        break;
                }

                Console.WriteLine(num5);
              
                int[] num = { num0, num1, num2, num3, num4, num5, num6, num7, num8, num9 };

                for (int h = 0 ; h < 10 ; h++)
                {
                    Console.WriteLine(num[h]);
                }

            }
                                

            
    
            //D 배열을 카운트
            //1,2,3,4,5,6,7,8,9
            //1,2,3, 2*2,2*3,2*2*2,3*3
            
            

        }
    }
}