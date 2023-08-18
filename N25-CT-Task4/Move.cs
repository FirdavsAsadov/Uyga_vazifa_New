using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_CT_Task4
{
    internal class Move
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }

        public Move(string name, string author, int rating)
        {
            Name = name;
            Author = author;
            Rating = rating;
        }
    }
}
