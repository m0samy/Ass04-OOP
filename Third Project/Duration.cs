using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class Duration
    {
        #region Attributes
        private int hours;
        private int minutes;
        private int seconds;
        #endregion

        #region Property
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        #endregion

        #region Constuctor
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;  // 1 hour = 3600 seconds
            totalSeconds %= 3600;         // Get the remaining seconds after hours
            Minutes = totalSeconds / 60;  // 1 minute = 60 seconds
            Seconds = totalSeconds % 60;  // Remaining seconds after minutes            
        }

        #endregion

        #region Methods Override
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Duration D)
            {
                return this.Hours == D.Hours &&
                       this.Minutes == D.Minutes &&
                       this.Seconds == D.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours , Minutes , Seconds);
        }
        #endregion

        #region operator oveloadig
        //1. Operator overloading for addition  D3=D1+D2
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) + (right?.Seconds ?? 0)
            };
        }

        //2. Operator overloading for  D3=D1 + 7800
        public static Duration operator +(Duration left, int right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + (right / 3600 ),
                Minutes = (left?.Minutes ?? 0) + (right % 3600 / 60),
                Seconds = (left?.Seconds ?? 0) + (right % 3600 % 60)
            };
        }

        //3.operator overloading for D3=666+D3
        public static Duration operator + (int left, Duration right)
        {
            return new Duration()
            {
                Hours = (left / 3600) + (right?.Hours ??0),
                Minutes = (left % 3600 / 60) + (right?.Minutes ?? 0),
                Seconds= (left % 3600 % 60) + (right?.Seconds ?? 0)
            };
        }

        //4. operator oveloading for D3= ++D1 (Increase One Minute)
        public static Duration operator ++(Duration d)
        {
            //return new Duration()
            //{
            //    Hours = d?.Hours ?? 0,
            //    Minutes = (d?.Minutes ?? 0) + 1,
            //    Seconds = d?.Seconds ?? 0
            //};
            d.Minutes++;
            if (d.Minutes >= 60)
            {
                d.Minutes = 0;
                d.Hours++;
            }
            return d;
        }

        //5. operator overloading D3 = --D2 (Decrease One Minute)
        public static Duration operator --(Duration d)
        {
            //return new Duration()
            //{
            //    Hours = d?.Hours ?? 0,
            //    Minutes = (d?.Minutes ?? 0) - 1,
            //    Seconds = d?.Seconds ?? 0
            //};
            d.Minutes--;
            if (d.Minutes == 0)
            {
                d.Minutes = 59;
                d.Hours--;
            }
            return d;
        }

        //6. operator oveloading for D1= D1 -D2
        public static Duration operator -(Duration left , Duration right)
        {
            if(left > right)
            {
                int second = ( (left.Hours * 3600) + (left.Minutes * 60) + (left.Seconds) ) -
                    ( (right.Hours * 3600) + (right.Minutes * 60) + (right.Seconds) );
                return new Duration(second);
            }
            else
            {
                return new Duration();
            }
        }

        //7.operator overloading for If (D1>D2)
        public static bool operator > (Duration left , Duration right)
        {
            return (left.Hours >  right.Hours) || (left.Minutes > right.Minutes) || (left.Seconds > right.Seconds);
        }
        public static bool operator <(Duration left, Duration right)
        {
            return (left.Hours < right.Hours) || (left.Minutes < right.Minutes) || (left.Seconds < right.Seconds);
        }

        //operator overloading for If (D1<=D2)
        public static bool operator <= (Duration left, Duration right)
        {
            return (left.Hours * 3600 + left.Minutes * 60 + left.seconds <= right.Hours * 3600 + right.Minutes * 60 + right.seconds);
        }
        public static bool operator >=(Duration left, Duration right)
        {
            return (left.Hours * 3600 + left.Minutes * 60 + left.seconds >= right.Hours * 3600 + right.Minutes * 60 + right.seconds);
        }

        //operator overloading for  if(D1) => true
        public static bool operator true (Duration D)
        {
            return (D.Hours != 0 || D.Minutes != 0 || D.Seconds != 0 );
        }
        public static bool operator false(Duration D)
        {
            return (D.Hours == 0 || D.Minutes == 0 || D.Seconds == 0);
        }
        #endregion
    }
}
