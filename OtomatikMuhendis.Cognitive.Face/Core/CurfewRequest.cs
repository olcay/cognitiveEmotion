using System;

namespace OtomatikMuhendis.Cognitive.Face.Core
{
    public class CurfewRequest
    {
        public CurfewRequest()
        {
        }

        public CurfewRequest(double age, DayOfWeek day, int hour)
        {
            Age = age;
            Day = day;
            Hour = hour;
        }

        public double Age { private get; set; }
        public DayOfWeek Day { private get; set; }
        public int Hour { private get; set; }

        public bool IsWeekend()
        {
            return Day == DayOfWeek.Saturday || Day == DayOfWeek.Sunday;
        }

        public bool IsUnder20()
        {
            return Age < 20;
        }

        public bool IsOver64()
        {
            return Age > 64;
        }

        public bool IsBetweenHours(int begin, int end)
        {
            return Hour >= begin && Hour <= end;
        }

        public bool IsOutsideOfHours(int begin, int end)
        {
            return Hour <= begin || Hour >= end;
        }
    }
}