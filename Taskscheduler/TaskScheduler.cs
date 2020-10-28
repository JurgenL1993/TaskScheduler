using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Intervals = Taskscheduler.Model.Intervals;
namespace Taskscheduler
{
    public class TaskScheduler
    {
        private static TaskScheduler _instance;
        private List<Timer> timers = new List<Timer>();

        private TaskScheduler() { }

        public static TaskScheduler Instance => _instance ?? (_instance = new TaskScheduler());

        public void ScheduleTask(int day, int month, int year, int hour, int min, Intervals inteval, Action task)
        {
            DateTime now = DateTime.Now;
            DateTime firstRun = new DateTime(year, month, day, hour, min, 0);

            double intervalInHour = 0;

            switch (inteval)
            {
                case Intervals.Hourly:
                    intervalInHour = 1;
                    break;
                case Intervals.Daily:
                    intervalInHour = 24;
                    break;
                case Intervals.Weekly:
                    intervalInHour = 168;
                    break;
            }

            if (now > firstRun)
            {
                firstRun = firstRun.AddDays(1);
            }

            TimeSpan timeToGo = firstRun - now;
            if (timeToGo <= TimeSpan.Zero)
            {
                timeToGo = TimeSpan.Zero;
            }

            var timer = new Timer(x =>
            {
                task.Invoke();
            }, null, timeToGo, TimeSpan.FromHours(intervalInHour));

            timers.Add(timer);
        }
    }
}
