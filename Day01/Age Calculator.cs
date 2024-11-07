using System;
namespace Brithdate
{
    class AgeCalculator
    {
        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0 || ((year % 4 == 0) && (year % 100 != 0)))
            {
                return true;
            }
            return false;
        }

        public int[] GetCurrentDate()
        {
            DateTime currentDate = DateTime.Today;

            return new int[] { currentDate.Year, currentDate.Month, currentDate.Day };
        }

        public int[] GetUserBirthdate()
        {
            int[] CurrentDate = GetCurrentDate();

            int year = 0;
            int month = 0;
            int day = 0;
            string ch = "";
            int febMaxDays = 28;
            int[] monthMaxDays = { 0, 31, febMaxDays, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            do
            {
                int yearUpperBound = CurrentDate[0];
                do
                {
                    Console.WriteLine($"Please Enter Your birth year [1980 - {yearUpperBound}]");
                    try { 
                        year = int.Parse(Console.ReadLine());
                        febMaxDays = IsLeapYear(year) ? 29 : 28;
                    }
                    catch
                    {
                        year = 0;
                    }


                } while (year < 1980 || year > yearUpperBound);

                int monthUpperBound = 12;
                do
                {
                    monthUpperBound = (year == CurrentDate[0]) ? CurrentDate[1] : 12;
                    Console.WriteLine($"Please Enter Your birth Month [1 - {monthUpperBound}]");
                    try { 
                        month = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        month = 0;
                    }

                } while (month < 1 || month > monthUpperBound );

                int dayUpperBound = monthMaxDays[month];
                do
                {
                    dayUpperBound = (month == CurrentDate[1]) ? CurrentDate[2] : dayUpperBound;
                    Console.WriteLine($"Please Enter Your birth Day [1 - {dayUpperBound}]");
                    try
                    {
                        day = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        day = 0;
                    }

                } while (day < 1 || day > dayUpperBound);
                Console.Clear();

                Console.WriteLine($"\t Your birthday is {day} / {month} / {year}");
                Console.WriteLine($"Would you like to adjust it?(Y/N)");
                ch = Console.ReadLine();

            } while (ch == "Y");

            return new int[] { year, month, day };

        }

        public void ClaculateAge()
        {

            int[] currentDate = GetCurrentDate();
            int[] UserBirthDate = GetUserBirthdate();
            Console.Clear();

            Console.WriteLine($"\t Your Birthdate  is {UserBirthDate[2]} / {UserBirthDate[1]} / {UserBirthDate[0]}");
            Console.WriteLine($"\t Current Date    is {currentDate[2]} / {currentDate[1]} / {currentDate[0]}");
            Console.WriteLine($"\t **************************************************************************");
            int[] monthMaxDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeapYear(currentDate[0]))
            {
                monthMaxDays[2] = 29;
            }

            int ageInYears = currentDate[0] - UserBirthDate[0];
            ageInYears = (ageInYears < 0) ? 0 : ageInYears;

            int ageInMonths = currentDate[1] - UserBirthDate[1];
            if (ageInMonths < 0)
            {
                ageInYears--;
                ageInMonths = ageInMonths + 12;
            }

            int ageInDays = currentDate[2] - UserBirthDate[2];
            if (ageInDays < 0)
            {
                ageInMonths--;
                ageInDays = ageInDays + monthMaxDays[UserBirthDate[1] - 1];
            }

            PrintUserAge(ageInYears, ageInMonths, ageInDays);
        }

        public void PrintUserAge(int ageInYears, int ageInMonths, int ageInDays)
        {
            Console.WriteLine($"You Are\n\t{ageInYears} Years, {ageInMonths} Months, {ageInDays} Days old! ");
        }

        public static void Start()
        {
            string ch = "Y";

            do
            {
                AgeCalculator ageCalc1 = new AgeCalculator();
                ageCalc1.ClaculateAge();
                Console.Write("Would you like to Use it again?(Y|N)");
                ch = Console.ReadLine().ToUpper();
            } while (ch.ToUpper() == "Y") ;

        }
    
       
    }
}
