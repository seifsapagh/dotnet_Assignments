using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Date(int year, int month, int day)
        {
            Year = year > DateTime.Now.Year || year < 1  ? 1970: year;
            Month = month > 12 || month < 1 ? 1 : month;
            Day = day > 31 || day < 1 ? 1 : day;
        }

        public override string ToString() {
            return $"{Year}-{Month}-{Day}";
        }

        public static bool operator >(Date d1, Date d2)
        {
            return (d1.Year > d2.Year) ||
                   (d1.Year == d2.Year && d1.Month > d2.Month) ||
                   (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day > d2.Day);
        }

        public static bool operator <(Date d1, Date d2)
        {
            return (d1.Year < d2.Year) ||
                   (d1.Year == d2.Year && d1.Month < d2.Month) ||
                   (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day < d2.Day);
        }



    }
}
