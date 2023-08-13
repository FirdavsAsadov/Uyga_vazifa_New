using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_CT_task1
{
    internal class University <TStudent, TId, TGrade> where TStudent : Studen<TId, TGrade>
    {
       public  List<TStudent> students = new List<TStudent>();
        public List<Course> courses = new List<Course>();
        public void EnrollStudent(TStudent student,Course course)
        {
            courses.Add(course);
            students.Add(student);
        }
    }
}
