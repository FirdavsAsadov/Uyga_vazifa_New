using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT_Task2
{
    internal class CrashReport : IReview
    {
        public Guid Id { get; set; }
        public int Star { get; set; }
        public string Message { get; set; }
        public string Screenshot { get; set; }

        public CrashReport(Guid id,int star, string message, string screenshot)
        {
            Id = id;
            Star = star;
            Message = message;
            Screenshot = screenshot;
        }
        
    }
}
