using System;
namespace WineBook.Models
{
    public enum ReleaseScheduleType
    {
        Weekly,
        Monthly,
        Quarterly,
        Yearly
    }

    public class ReleaseSchedule
    {
        public int ReleaseScheduleId { get; set; }
        public ReleaseScheduleType ReleaseScheduleType { get; set; }
    }
}
