using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_CT_task1.Modul
{
    internal class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public bool IsCompleted { get; set; }
        public readonly List<string> Comments;
    }
}
