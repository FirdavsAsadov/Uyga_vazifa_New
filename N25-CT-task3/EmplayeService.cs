using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace N25_CT_task3
{
    internal class EmplayeService 
    {
       private List<Emplyee> employe;
        public EmplayeService(List<Emplyee> initialEmploye)
        {
            employe = initialEmploye;
        }
        public IEnumerable<Emplyee> GetBySalary(int pageSize, int pageToken)
        {
            var sortedEmploye = employe.OrderByDescending(x => x.Salary);
            var paginatedEmployee = sortedEmploye.Skip((pageToken - 1) * pageSize).Take(pageSize);
            return paginatedEmployee;
        }
    }
}
