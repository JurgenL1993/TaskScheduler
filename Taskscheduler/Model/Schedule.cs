using System;
using System.Collections.Generic;
using System.Text;

namespace Taskscheduler.Model
{
    public class Schedule
    {
        /// <summary>
        /// Gets or Sets Id of Schedule
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or Sets the Day of Schedule
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// Gets or Sets the Month of Schedule
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Gets or Sets the Year of Schedule
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets the Hour of Schedule
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// Gets or Sets the Min of Schedule
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// Gets or Sets the Schedule Type
        /// </summary>
        public Type ScheduleType { get; set; }

        /// <summary>
        /// Gets or Sets the Interval Type
        /// </summary>
        public Intervals Interval { get; set; }
    }


    public enum Type
    {
        Daily = 1,
        Weekly = 2,
        Monthly = 3
    }
    public enum Intervals
    {
        Hourly = 1,
        Daily = 2,
        Weekly = 3,
    }
}
