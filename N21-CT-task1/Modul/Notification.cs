using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_CT_task1.Modul
{
    internal class Notification
    {
        public User Recipient { get; set; }
        public string Message { get; set; }
        public DateTime Timsestamp { get; set; }
    }
}
