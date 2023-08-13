using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_CT_task1
{
    internal class Studen<TId, TGrade>
    {
        public TId Id { get; set; }
        public TGrade Grade { get; set;}
        public string Name { get; set; }

        public Studen(TId id, TGrade grade, string name)
        {
            Id = id;
            Grade = grade;
            Name = name;
        }
    }
}
