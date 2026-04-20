using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2
{
    internal class Time
    {
        byte _hours;
        byte _minutes;
        public Time(byte hours, byte minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public byte Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value < 24)
                {
                    _hours = value;
                } 
            }
        }
        public byte Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value < 60)
                {
                    _minutes = value;
                }
            }
        }
        public static Time operator -(Time t1, Time t2)
        {
            int totalmin_1 = t1._hours * 60 + t1._minutes;
            int totalmin_2 = t2._hours * 60 + t2._minutes;
            int res = totalmin_1 - totalmin_2;
            if (res < 0)
            {
                res += 1440;
            } 
            byte hours = (byte)(res / 60);
            byte minutes = (byte)(res % 60);

            return new Time(hours, minutes); 
        }
        //3 задание 
        //УНАРНЫЕ ОПЕРАЦИИ 
        public static Time operator ++(Time t1)
        {
            int totalmin =t1 ._hours * 60 + t1._minutes + 1;
            if (totalmin >= 1440)
            {
                totalmin = 0;
            }
            return new Time((byte)(totalmin / 60), (byte)(totalmin % 60));
        }
        public static Time operator --(Time t1)
        {
            int totalmin = t1._hours * 60 + t1._minutes - 1;
            if (totalmin < 0)
            {
                totalmin = 1439;
            }
            return new Time((byte)(totalmin / 60), (byte)(totalmin % 60));
        }

        //ОПЕРАЦИИ ПРИВЕДЕНИЯ ТИПА

        public static implicit operator int(Time t1)
        {
            return t1._hours * 60 + t1._minutes;
        }
        public static explicit operator bool(Time t1)
        {
            return !(t1._hours == 0 && t1._minutes == 0);
        }


        //БИНАРНЫЕ ОПЕРЦИИ
        public static bool operator <(Time t1, Time t2)
        {
            int totalmin1 = t1._hours * 60 + t1._minutes;
            int totalmin2 = t2._hours * 60 + t2._minutes;
            return totalmin1 < totalmin2;
        }

        public static bool operator >(Time t1, Time t2)
        {
            int totalmin1 = t1._hours * 60 + t1._minutes;
            int totalmin2 = t2._hours * 60 + t2._minutes;
            return totalmin1 > totalmin2;
        }


        public override string ToString()
        {
            return $"{_hours:D2}:{_minutes:D2}";
        }

    }
}
