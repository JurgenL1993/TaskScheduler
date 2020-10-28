using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Taskscheduler.Model;

namespace Taskscheduler
{
    public class ReadFile
    {
        private static ReadFile _instance;
        private List<Task> tasks = new List<Task>();

        private ReadFile() { }

        public static ReadFile Instance => _instance ?? (_instance = new ReadFile());

        public List<Task> ReadJsonFile()
        {
            using (StreamReader r = new StreamReader(@"C:\\Users\\Jurgen\\Downloads\\TaskJson.json"))
            {
                string json = r.ReadToEnd();
                tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            }
            return tasks;
        }
    }
}
