using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Book
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Author { get; set; }

        public Book(string name, int rating, string author)
        {
            Name = name;
            Rating = rating;
            Author = author;
        }
    }
}
