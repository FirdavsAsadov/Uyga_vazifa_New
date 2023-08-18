using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_CT_task3
{
    internal class Emplyee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int KPI { get; set; }
        public Emplyee(string firstName, string lastName, decimal salary, int kpi)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            KPI = kpi;
        }
    }
}
