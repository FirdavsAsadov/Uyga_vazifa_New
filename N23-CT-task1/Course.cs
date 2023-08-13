using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_CT_task1
{
    internal class Course
    {
        public Guid CourseID { get; set;}
        public string Title { get; set; }

        public Course(string title)
        {
            Title = title;
            CourseID = Guid.NewGuid();  
        }
    }
}
