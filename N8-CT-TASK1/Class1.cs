using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_Task1
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Payment { get; set; }
        public string EduType { get; set; }
        public int PaymentAmount { get; set; }

        public string GetShortName() => FullName.PadRight(45,' ');

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDay.Year;
        }

        public string GetAmount()
        {
            decimal result = Payment - PaymentAmount;
            if (result < 0) return $"{result} haqdor";
            else return $"{result} qarzdor";
            
        }
    }
}