using System;

namespace DateTimePlay
{
    public static class DateRangeExtensionMethods
    {
        public static bool Overlaps(this IDateRange dateRange, IDateRange otherRange)
        {
            throw new System.NotImplementedException();
            //return false;
        }

        public static int DayCount(this IDateRange dateRange)
        {   
            return (dateRange.End - dateRange.Start).Value.Days;
        }
    }
}