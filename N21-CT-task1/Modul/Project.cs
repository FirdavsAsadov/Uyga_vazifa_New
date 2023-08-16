using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_CT_task1.Modul
{
    internal class Project
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public readonly List<Task> Tasks;
        public void AddTasks(Task tasks)
        {

        }
        public override string ToString()
        {
            return $"Project ID: {Id}\nTitle: {Title}\nDescription: {Description}";
        }

    }
}
