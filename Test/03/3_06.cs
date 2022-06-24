using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 클래스 상속 연습문제
 */
namespace Test
{
	class Rent
	{
		public void Payment()
		{
            Console.WriteLine("임대료를 받습니다.");
		}
	}

	class Landload : Rent
	{
		public void GetMoney()
		{
			Console.WriteLine("건물주 입니다.");
			Payment();
		}
	}

internal class _3_06
    {
        static void Main6(string[] args)
        {
			Landload master = new Landload();
			master.GetMoney();
		}
    }
}


