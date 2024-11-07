using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Duration
    {
        public int Hours { set; get; }
        public int Mins {set;get;}
        public int Secs { set; get; }

        public Duration(int h=0,int m=0, int s=0)
        {
            Hours = h;
            Mins = m;
            Secs = s;
        }
        public Duration(int s)
        {
            Secs = s % 60;
            Mins = (s / 60) % 60;
            Hours = s / 60 / 60;
        }

        public int ToSeconds()
        {
            int s = 0;
            s += Hours * 60 * 60;
            s += Mins * 60;
            s += Secs;
            return s;
        }

        #region  Overloading Operators
        // Greater Than 
        public static bool operator > (Duration d1, Duration d2)
        {
             return d1.ToSeconds() > d2.ToSeconds();
        }
        // Less Than
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToSeconds() < d2.ToSeconds();
        }

        // Equality
        public static bool operator ==(Duration d1, Duration d2)
        {
            return d1.ToSeconds() == d2.ToSeconds();
        }
        
        // inequality
        public static bool operator !=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() != d2.ToSeconds();
        }

        // Greater Than or Equal
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1.ToSeconds() > d2.ToSeconds()) || (d1.ToSeconds() == d2.ToSeconds());
        }
        // Less Than or Equal
        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1.ToSeconds() < d2.ToSeconds()) || (d1.ToSeconds() == d2.ToSeconds());
        }
        
        

        // Addition 
        public static Duration operator+(Duration d1, Duration d2)
        {
            return new Duration(d1.ToSeconds() + d2.ToSeconds());
        }
        public static Duration operator +(Duration d1, int num)
        {
            Duration d2 = new(num);
            return d1 + d2;

        }
        public static Duration operator ++(Duration d1)
        {
            return new Duration(d1.ToSeconds() + 60);
        }


        // Subtraction 
        public static Duration operator -(Duration d1, Duration d2)
        {
            if(d1 < d2)
            {
                Duration temp = d1;
                d1 = d2;
                d2 = temp;
            }
            return new Duration(d1.ToSeconds() - d2.ToSeconds());
        }
        public static Duration operator -(Duration d1, int num)
        {
            Duration d2 = new(num);
            return d1 - d2;

        }
        public static Duration operator --(Duration d1)
        {
            return new Duration(d1.ToSeconds()-60);
        }


        #endregion

        public override string ToString()
        {
            string h,m,s;
            h = (Hours == 0) ? "" : $"Hours: {Hours}";
            if (Hours != 0 && Mins != 0) h += ", ";

            m = (Mins == 0 ) ? "" : $"Minutes: {Mins}";

            if (Secs == 0)
            {
                s = "";
            }else if (Mins != 0 || Hours != 0)
                
            {
                s = $", Seconds: {Secs}";
            }
            else
            {
                s = $"Seconds: {Secs}";
            }

            return $"{h}{m}{s}";
        }
        
    }
}
