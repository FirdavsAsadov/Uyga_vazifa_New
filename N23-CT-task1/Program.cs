using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_CT_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studen<Guid, string> studen1 = new Studen<Guid, string>(Guid.NewGuid(), "Middle", "Jasur");
            Studen<Guid, string> studen2 = new Studen<Guid, string>(Guid.NewGuid(), "Senior", "Jahon");
            Course course1 = new Course("Dotnet Botcamp");
            Course course2 = new Course("NodeJS Botcamp");
            University<Studen<Guid, string>, Guid, string> university = new University<Studen<Guid, string>, Guid, string>();
            university.EnrollStudent(studen1, course1);
            university.EnrollStudent(studen2, course2);
            university.students.ForEach(student => { Console.WriteLine(student.Grade + "    " +student.Name); });
            Console.WriteLine();

        }
    }
}
