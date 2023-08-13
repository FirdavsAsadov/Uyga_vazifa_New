using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT_Task2
{
    internal interface IReview
    {
        public Guid Id { get; set; }
        public int Star { get; set; }

        public string Message { get; set; }
    }
}
