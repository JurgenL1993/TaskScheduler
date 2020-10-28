using System;
using System.Threading;
namespace Taskscheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = ReadFile.Instance.ReadJsonFile();

            for (int i = 0; i < tasks.Count; i++)
            {
                var task = tasks[i];
                for (int j = 0; j < task.Schedules.Count; j++)
                {
                    var schedule = task.Schedules[j];

                    TaskScheduler.Instance.ScheduleTask(schedule.Day, schedule.Month, schedule.Year, schedule.Hour, schedule.Min, schedule.Interval,
                    () =>
                        {
                            Console.WriteLine("TASK:" + " - " + schedule.Id + DateTime.Now);
                        });
                    }
                
            }
            
            Console.ReadLine();
        }
    }
}
