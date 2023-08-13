using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT_Task2
{

    internal class Review : IReview
    {
        public Guid Id { get; set; }
        public int Star { get; set; }
        public string Message { get; set; }

        public Review(Guid id, int star, string message)
        {
            Id = id;
            Star = star;
            Message = message;
        }
    }
}
