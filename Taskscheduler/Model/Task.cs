using System;
using System.Collections.Generic;
using System.Text;

namespace Taskscheduler.Model
{
    public class Task
    {

        public Task()
        {
            Schedules = new List<Schedule>();
        }

        /// <summary>
        /// Gets or sets the Id of Task
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of Task
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description of Task
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the List of Schedules
        /// </summary>
        public List<Schedule> Schedules { get; set; }
    }
}
