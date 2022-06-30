using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//yesr = isleapyear
namespace Test._9
{
    internal class _9_08
    {
        static void Main(string[] args)
        {
            Console.Write("생일 입력(yyyy/mm/dd) : ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split("/");

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int totalDays = 0;

            //올해 1월 1일부터 오늘까지 날짜 수
            totalDays += DayOfYear(tYear, tMonth, tDay);

            //태어난 해의 생일부터 그해 마지막 날까자의 날짜 수
            int yearDays = IsLeapYear(bYear) ? 366 : 365;
            totalDays += yearDays - DayofYear(bYear, tMonth, tDay)

             for(int year =bYear+1;year <tYear; year++)
            {
                if(year == IsLeapYear)
            }
        }
    }
}
