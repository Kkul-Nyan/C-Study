using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._007단계
{
    internal class 기본수학006
    {
        static void Main1(string[] args)
        {

            int RepearNum = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < RepearNum; i++)
            {
                int Sum = 0;
                int FloorNum = int.Parse(Console.ReadLine());
                int RoomNum = int.Parse(Console.ReadLine());

                int[,] HouseNum = new int[15,15];
                for(int j = 0; j < 15; j++)
                {
                    HouseNum[j, 1] = 1;
                }
                for(int j = 1; j < 15; j++)
                {
                    HouseNum[0, j] = j;
                }
                
                for(int j = 1; j < 15; j++)
                {
                    for(int k = 2; k<15; k++)
                    {
                        HouseNum[j, k] = HouseNum[(j - 1), k] + HouseNum[j, (k - 1)];
                    }
                }
                Console.WriteLine(HouseNum[FloorNum,RoomNum]);
            }
        }
    }
}
