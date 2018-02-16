using System;

namespace DateTimePlay
{
    public class DateRange : IDateRange
    {
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public DateRange() { }
        public DateRange(DateTime Start, DateTime End)
        {
            this.Start = Start;
            this.End = End;
        }
    }
}
