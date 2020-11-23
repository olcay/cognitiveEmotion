using System;

namespace OtomatikMuhendis.Cognitive.Face.Services
{
    public class CurfewService : ICurfewService
    {
        private bool IsWeekendDay(DateTimeOffset date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public bool IsFreeToGoOut(double? age, DateTimeOffset time)
        {
            if (age == null)
            {
                Console.WriteLine("Age is not calculated.");
                return false;
            }

            var info = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
            var dateTime = TimeZoneInfo.ConvertTime(time, info);

            if (!IsWeekendDay(dateTime))
            {
                if (age <= 20)
                {
                    return !(dateTime.Hour <= 13 || dateTime.Hour >= 16);
                }

                if (age > 65)
                {
                    return (dateTime.Hour >= 10 || dateTime.Hour <= 13);
                }
                return true;
            }

            if (dateTime.Hour <= 10) return false;
            if (dateTime.Hour >= 20) return false;
            if (dateTime.Hour > 20) return true;
            if (age <= 20)
            {
                return dateTime.Hour > 13 && dateTime.Hour < 16;
            }

            if (age > 65)
            {
                return dateTime.Hour >= 10 || dateTime.Hour <= 13;
            }
            return true;
        }
    }
}
