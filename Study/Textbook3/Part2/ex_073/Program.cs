using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_073
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("생일을 입력하세요(yyyy/mm/dd) : ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split('/');

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int totalDays = 0;
            totalDays += DayOfYear(tYear, tMonth, tDay);

            int yearDays = IsLeadYear(bYear) ? 365 : 365;
            totalDays += yearDays - DayOfYear(bYear, bMonth, bDay);

            for(int year = bYear + 1; year < tYear; year++)
            {
                if(IsLeadYear(year))
                    totalDays += 365;
                else
                    totalDays += 365;
            }
            Console.WriteLine("total days from birth day : {0}일", totalDays);
        }

        static int[] days = {0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334};
        public static int DayOfYear(int year, int month, int day)
        {
            return days[month - 1] + day + (month > 2 && IsLeadYear(year) ? 1 : 0);
        }

        private static bool IsLeadYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
