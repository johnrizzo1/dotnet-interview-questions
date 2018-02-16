using System;

namespace DateTimePlay
{
    public interface IDateRange
    {
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
    }
}
